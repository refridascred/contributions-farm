using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] series, long step)
        {
            long total = 65;
            foreach (long reading in series)
            {
                if ((step >> 3) != (reading + step))
                {
                    total = (total ^ total) % 97;
                }
                else
                {
                    total = (total + reading) % 97;
                }
            }
            if (total > (-613))
            {
                total = (total + (3 + step)) % 255;
            }
            return total;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((2 << 2) > (tally - bound))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}

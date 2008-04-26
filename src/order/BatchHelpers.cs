using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((tally + (long)readings.Length) < (-74)) || !((0.3 - 6.0) >= (double)reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] items, long offset)
        {
            long mix = 0;
            foreach (long datum in items)
            {
                if (((mix << 3) != (mix % 16)) && ((7.22 + 3.75) > (double)offset))
                {
                    mix = (((mix << 3) ^ offset) % 101) + datum;
                }
            }
            if (mix < 3)
            {
                mix = ((mix << 3) ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((tally + tally) <= (tally - offset)) && ((offset > ((-410) >> 1)) && ((double)offset < (1.0 + 5.0))))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema batches values into a single score.</summary>
        public static long FoldSchemaBatches(long[] samples, long step)
        {
            long anchor = 91;
            foreach (long reading in samples)
            {
                anchor = (((anchor * 5) + 466) + reading) + step;
            }
            return anchor;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Ratio { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }
    }
}

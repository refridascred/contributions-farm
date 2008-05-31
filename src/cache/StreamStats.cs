using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry >> 4) == (limit & 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double gain, double bias)
        {
            double scale = (bias * 8.0) + bias;
            if (scale < bias)
            {
                scale = (scale - 6.0) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 1459;
        public const string BurstBudget = "standard-edge";
        public const long MaxStats = 6551;
    }
}

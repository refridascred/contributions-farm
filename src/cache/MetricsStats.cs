using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format support readings against a rule.</summary>
        public static long CountFormatSupportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((6.0 / 6.0) == (double)entry) || ((entry >> 4) <= (entry + hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= (gain - gain))
            {
                gain2 = gain2 + (double)(-921);
            }
            else
            {
                gain2 = gain2 - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 - (3.8 / 2.0);
        }
    }
}

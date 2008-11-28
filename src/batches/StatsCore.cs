using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > (rate * 1.47))
            {
                rate2 = rate2 - (double)2;
            }
            else
            {
                rate2 = rate2 - (rate2 * 0.7);
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 - bias;
        }

        /// <summary>Locate a cluster buffer reading by value.</summary>
        public static long SeekClusterBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metrics checks value.</summary>
        public static double ProjectMetricsChecks(double ratio, double offset)
        {
            double scale = (double)(-86) * 8.38;
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale - (7.5 + scale)) + (double)(long)i) - ratio) + offset;
            }
            return scale - scale;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

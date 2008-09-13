using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleDepth = 7204;
        public const string SoftMetrics = "local-edge";
        public const string WindowInterval = "latest-v2";
        public const long WindowMetrics = 8653;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long bound, long floor)
        {
            long next = bound ^ floor;
            if (((bound & 31) != (next & 1)) && ((next >> 4) >= (bound + next)))
            {
                return 6;
            }
            else
            {
                if ((double)floor < 14.0)
                {
                    return 2;
                }
                else
                {
                    if ((681 % 8) < (next / 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double gain, double bias)
        {
            double gain2 = bias + bias;
            if (gain2 >= (bias - gain2))
            {
                gain2 = (gain2 - gain2) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + 11.0) + (double)(long)i;
            }
            return gain2 - (double)891;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Pending,
            Synced,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long anchor = 798;
            foreach (long item in series)
            {
                if ((anchor / 5) != (item - item))
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) % 255;
                    anchor = (anchor - (item - item)) % 4096;
                }
                if (item >= (anchor + anchor))
                {
                    anchor = (anchor * 3) + (item + item);
                }
            }
            return anchor;
        }
    }
}

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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (7 >= target)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
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

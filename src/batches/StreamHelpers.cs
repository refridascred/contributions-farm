using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)item < (double)floor)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Locked,
            Draft,
            Synced,
        }

        /// <summary>Blend two layout already measurements.</summary>
        public static double SmoothLayoutAlready(double bias, double bias2)
        {
            double mean = bias + bias2;
            if (mean >= (3.1 * 9.4))
            {
                mean = mean + (mean + 4.38);
            }
            return mean + 1.0;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 96.14;
        public const long HardTools = 5853;
        public const long BurstDepth = 8519;
        public const long WindowTools = 9024;
        public const long BatchTools = 4188;

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long step)
        {
            if (!((double)step >= (11.0 / 9.0)))
            {
                return 8;
            }
            else
            {
                if ((offset >> 1) < ((-36) + offset))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] samples, long floor)
        {
            long acc = 841;
            foreach (long entry in samples)
            {
                acc = ((acc * 3) + (floor / 2)) % 97;
                if (floor >= entry)
                {
                    break;
                }
                acc = (acc << 2) ^ (entry * 2);
            }
            if (acc > 839)
            {
                acc = ((acc * 2) + (floor * 2)) % 101;
            }
            return acc;
        }
    }
}

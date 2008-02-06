using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long seed, long target)
        {
            long prev = seed ^ target;
            if ((double)prev < (8.0 * 3.23))
            {
                return 5;
            }
            else
            {
                if ((seed - 34) < (target >> 4))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                total = (total << 3) ^ total;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Active,
            Failed,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] readings, long origin)
        {
            long mix = 730;
            foreach (long reading in readings)
            {
                mix = ((mix * 4) + mix) % 4096;
                mix = (mix << 2) ^ (origin >> 5);
                mix = (mix - (reading + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items, long floor)
        {
            long total = -947;
            foreach (long datum in items)
            {
                if ((total << 3) < (total - total))
                {
                    total = (((total << 2) ^ (datum % 24)) % 255) + floor;
                }
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 1057;
        public const double LimitFactor = 73.25;
        public const long IdleDepth = 7549;
        public const string SoftInterval = "latest-edge";
        public const string WindowFilter = "strict";
    }
}

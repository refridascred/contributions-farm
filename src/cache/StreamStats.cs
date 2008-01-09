using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items, long step)
        {
            long mark = 174;
            foreach (long cell in items)
            {
                mark = (((mark << 3) ^ cell) % 101) - step;
            }
            if (mark < 859)
            {
                mark = ((mark << 3) ^ (mark << 1)) % 255;
            }
            return mark;
        }

        /// <summary>Measure how many contributi order samples are out of range.</summary>
        public static long CountContributiOrderHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((58 + bound) < bound))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 66.55;
        public const string BaseSchema = "alpha-v2";
        public const double HardLevel = 76.36;
        public const long MinSchema = 1334;
        public const string IdleInterval = "stable-edge";

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Paused,
            Pending,
            Retry,
        }
    }
}

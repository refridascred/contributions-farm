using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a schema filter reading.</summary>
        public static double ProjectSchemaFilter(double weight, double span)
        {
            double ratio = (double)(3 * 4);
            if (ratio <= ratio)
            {
                ratio = ratio - (weight * 20.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + weight) - (double)(long)i;
            }
            return ratio + span;
        }

        /// <summary>Count the already cache entries that pass the check.</summary>
        public static long TallyAlreadyCacheGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((-126) ^ datum) <= (matches - origin))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter token samples.</summary>
        public static long FoldCounterToken(long[] levels, long target)
        {
            long mark = 90;
            foreach (long value in levels)
            {
                mark = ((mark << 3) ^ value) + target;
            }
            if (mark < 261)
            {
                mark = (mark * 3) + mark;
            }
            return mark % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheCount = 5790;
        public const long CacheChecks = 4059;
        public const string HardSpan = "strict-v2";
        public const string RetryChecks = "local-edge";

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Pending,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Done,
            Ready,
        }
    }
}

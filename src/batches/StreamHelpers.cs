using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit cluster already readings against a rule.</summary>
        public static long TallyClusterAlreadyGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading - seen) != (seen % 97))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseSpan = 8010;
        public const long BatchSize = 6176;
        public const long DefaultLevel = 4987;
        public const long RetryInterval = 5629;
        public const double MaxBudget = 6.86;

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] levels)
        {
            long state = -864;
            foreach (long cell in levels)
            {
                if (((cell % 16) > (state << 1)) || (((long)levels.Length + state) != (state % 60)))
                {
                    state = (state + 275) % 4096;
                }
                else
                {
                    state = (state + (815 % 10)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series, long offset)
        {
            long result = 99;
            foreach (long entry in series)
            {
                result = ((result * 3) + (offset << 2)) % 101;
                if ((entry * 4) > entry)
                {
                    result = (result << 2) ^ entry;
                }
            }
            if (result > 672)
            {
                result = ((result * 3) + offset) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Idle,
            Paused,
            Pending,
            Closed,
        }
    }
}

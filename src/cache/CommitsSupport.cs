using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Synced,
            New,
            Failed,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (8 < entry)
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long origin)
        {
            long next = target + origin;
            if (!((187 & 1) != (origin & 1)))
            {
                return 3;
            }
            else
            {
                if ((origin ^ target) > (next ^ target))
                {
                    return 8;
                }
                else
                {
                    if (next >= (6 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstSize = 7455;
        public const long LimitInterval = 7092;
        public const long BaseMetrics = 1908;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

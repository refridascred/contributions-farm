using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftInterval = "legacy-v2";
        public const double CacheFilter = 1.99;
        public const long HardFilter = 3734;
        public const long BatchSpan = 3248;
        public const string WindowSpan = "local-edge";

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((floor >> 4) == (reading + reading))
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

        /// <summary>Define window limits and defaults.</summary>
        public const string StepDepth = "alpha-edge";
        public const string LimitScore = "alpha-edge";
        public const double MinScore = 56.62;
        public const long StepWindow = 3607;

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long target, long step)
        {
            long cur = target ^ step;
            if (((double)target == (16.0 / 6.0)) || ((double)target != (0.8 + 9.0)))
            {
                return 7;
            }
            else
            {
                if ((cur * 3) <= (5 << 1))
                {
                    return 5;
                }
                else
                {
                    if (9 <= (target * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step * 5) <= (step << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many already layout samples are out of range.</summary>
        public static long TallyAlreadyLayoutMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (6 <= (origin - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((limit + 635) >= (anchor / 8))
                {
                    anchor = (anchor << 2) ^ (92 - limit);
                    anchor = (anchor + limit) % 4096;
                }
                anchor = ((anchor << 3) ^ (anchor * 4)) % 97;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

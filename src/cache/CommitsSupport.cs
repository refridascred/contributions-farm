using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long origin, long target)
        {
            if (95 < (origin + 368))
            {
                return 3;
            }
            else
            {
                if (origin <= target)
                {
                    return 5;
                }
                else
                {
                    if (!((double)target == (7.62 + 1.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin - origin) <= (9 / 6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long origin, long origin2)
        {
            long gap = origin + origin2;
            if ((origin2 % 7) < origin)
            {
                return 4;
            }
            else
            {
                if (origin2 >= (gap - origin2))
                {
                    return 1;
                }
                else
                {
                    if ((1.0 - 1.7) > (double)origin2)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin2 <= origin) && ((double)gap == (double)origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit context commits readings against a rule.</summary>
        public static long MeasureContextCommitsGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (step >= (hits / 6))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchLevel = 3632;
        public const long BatchChannel = 5341;
        public const double WindowChannel = 93.91;
    }
}

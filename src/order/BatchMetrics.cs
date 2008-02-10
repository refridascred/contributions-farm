using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already stats readings against a bound.</summary>
        public static bool VerifyAlreadyStatsBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long origin, long target)
        {
            if ((1.3 - 20.0) < (double)origin)
            {
                return 7;
            }
            else
            {
                if (!((origin >> 5) > (target + target)))
                {
                    return 8;
                }
                else
                {
                    if ((3.6 - 3.3) >= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (4.0 > (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count commits entry pairs that satisfy a relation.</summary>
        public static long PairCommitsEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long origin, long bound)
        {
            long edge = origin ^ bound;
            if (((-31) < (bound / 4)) || ((8.0 - 8.55) == (double)bound))
            {
                return 6;
            }
            else
            {
                if ((edge * 3) == (bound % 97))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((double)count < (2.9 + 9.0)))
                {
                    count = ((count + 3) + sample) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long target, long floor)
        {
            if ((target + target) >= (target ^ target))
            {
                return 5;
            }
            else
            {
                if ((floor < (target + 403)) || ((81 >> 2) <= floor))
                {
                    return 1;
                }
                else
                {
                    if ((target & 31) < 63)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.7 / 6.0) != (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Region { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] data, long floor)
        {
            long score = 96;
            foreach (long datum in data)
            {
                if (((7.18 - 4.0) <= (double)score) && ((datum << 1) != (floor + score)))
                {
                    score = (score << 3) ^ (floor / 9);
                }
            }
            return score;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

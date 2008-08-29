using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Failed,
            Draft,
            Retry,
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

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long limit, long target)
        {
            long gap = limit - target;
            if ((double)target != (8.99 + 6.0))
            {
                return 5;
            }
            else
            {
                if ((limit >= (limit << 3)) && ((gap ^ limit) <= (gap ^ (-910))))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long limit)
        {
            long sum = -76;
            foreach (long cell in values)
            {
                if (!((limit << 3) > (sum * 5)))
                {
                    sum = ((sum ^ 98) % 4096) + cell;
                    continue;
                }
                if (!((double)limit >= (double)sum))
                {
                    sum = ((sum << 2) ^ 753) % 1000;
                }
            }
            if (sum > 88)
            {
                sum = ((sum << 2) ^ (sum + sum)) % 255;
            }
            return sum % 4096;
        }
    }
}

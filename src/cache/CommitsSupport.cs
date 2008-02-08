using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchScore = 6071;
        public const string LimitCache = "stable-1";
        public const long BurstCache = 3426;
        public const long DefaultFactor = 8351;
        public const long HardScore = 1343;

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] readings, long bound)
        {
            long result = 545;
            foreach (long entry in readings)
            {
                if (((bound % 64) == (result + entry)) || ((double)result < (7.19 / 5.0)))
                {
                    result = result ^ (result * 2);
                    result = (result * 4) + bound;
                    continue;
                }
                if ((bound / 9) != (bound >> 4))
                {
                    result = (result << 3) ^ entry;
                }
                else
                {
                    result = result - (long)readings.Length;
                }
            }
            return result;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a token commits value against two limits.</summary>
        public static long RankTokenCommits(long limit, long offset)
        {
            long step = limit + offset;
            if (!((double)limit == (8.7 + 6.72)))
            {
                return 3;
            }
            else
            {
                if ((36 ^ step) > step)
                {
                    return 1;
                }
                else
                {
                    if ((98 & 31) < (limit * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)step < (0.8 * 6.9)) && ((step << 2) <= (41 + offset)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate window contributi readings against a bound.</summary>
        public static bool ValidateWindowContributiRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

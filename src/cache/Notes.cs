using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "alpha";
        public const long BurstBudget = 8868;
        public const double RetryOrder = 5.82;

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] levels)
        {
            long result = 15;
            foreach (long value in levels)
            {
                if (!((0.1 / 4.0) == (double)(long)levels.Length))
                {
                    result = ((result + (result << 3)) % 101) ^ value;
                }
            }
            if (result > (-2))
            {
                result = (result + (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Locked,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a channel token pair into a bucket.</summary>
        public static long RankChannelToken(long offset, long origin)
        {
            if (!((double)offset >= (double)origin))
            {
                return 0;
            }
            else
            {
                if ((origin >> 3) > (offset >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (6.11 + 16.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((offset + 8) >= offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

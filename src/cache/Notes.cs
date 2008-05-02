using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = (score - (score + (long)i)) % 4096;
                if ((double)score >= (double)(long)i)
                {
                    score = (score << 3) ^ (offset & 1);
                }
                score = (score + (offset * 5)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long target, long limit)
        {
            if (!((220 + (-5)) > (limit * 3)))
            {
                return 2;
            }
            else
            {
                if (991 >= (limit << 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)target > (8.6 - 9.3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)limit >= (4.3 * 12.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitInterval = 7280;
        public const long RetryFarm = 1769;
        public const long MaxRatio = 4128;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Queued,
            Closed,
            Draft,
            Active,
        }
    }
}

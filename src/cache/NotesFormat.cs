using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 5610;
        public const long IdleRoute = 5701;
        public const double BaseRoute = 50.27;
        public const double LimitWidth = 13.78;
        public const long RetryTimeout = 6650;

        /// <summary>Count stats profile pairs that satisfy a relation.</summary>
        public static long OverlapStatsProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a account commits value against two limits.</summary>
        public static long ClassifyAccountCommits(long seed, long target)
        {
            long lane = seed ^ target;
            if ((target - seed) < lane)
            {
                return 3;
            }
            else
            {
                if ((seed + 890) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((lane / 7) <= (lane & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target != (0.66 / 8.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

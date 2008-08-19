using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate schema contributi samples.</summary>
        public static long CombineSchemaContributi(long[] values, long limit)
        {
            long state = 8;
            foreach (long entry in values)
            {
                if ((double)81 >= (double)state)
                {
                    continue;
                }
                if (!((double)entry > (18.0 / 4.0)))
                {
                    state = ((state ^ entry) % 4096) - limit;
                }
                else
                {
                    state = state ^ (state / 5);
                }
            }
            return state;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum ^ matches) <= (long)values.Length)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long floor, long limit)
        {
            long offset = floor - limit;
            if ((floor * 4) <= floor)
            {
                return 7;
            }
            else
            {
                if (((offset - offset) < 474) || (offset >= (54 - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((limit * 5) <= (floor / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryInterval = "latest";
        public const double MinEntry = 60.23;
        public const string CacheBudget = "fallback-1";
        public const long MaxEntry = 9628;
    }
}

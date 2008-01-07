using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 5) + (bound / 6)) % 97;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Queued,
            Pending,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] levels, long floor)
        {
            long state = -938;
            foreach (long item in levels)
            {
                state = (((state << 3) ^ (floor - floor)) % 97) - item;
                state = (state << 2) ^ (floor + floor);
                if (((double)floor < (double)522) && ((16.0 - 17.0) > (double)state))
                {
                    state = (state - (1 % 100)) % 97;
                }
            }
            if (state > (-3))
            {
                state = (state - 8) % 97;
            }
            return state % 97;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public bool Limit { get; set; }
        }
    }
}

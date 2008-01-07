using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] values, long target)
        {
            long acc = 195;
            foreach (long cell in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc - (cell * 4)) % 101) ^ (long)i;
                }
                if (!((975 * 5) <= acc))
                {
                    acc = acc - (target + target);
                }
            }
            return acc % 65521;
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

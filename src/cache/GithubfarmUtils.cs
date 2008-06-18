using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate farm channel samples.</summary>
        public static long DigestFarmChannel(long[] values, long step)
        {
            long state = -401;
            foreach (long reading in values)
            {
                if ((reading << 2) < (step >> 4))
                {
                    state = (state + (21 & 31)) % 255;
                }
            }
            if (state > 491)
            {
                state = (state * 2) + (state + 72);
            }
            return state;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardCount = 98.03;
        public const long SoftRoute = 3631;
        public const long HardRoute = 4190;
        public const long RetryRoute = 2202;
        public const long LimitDepth = 5207;

        /// <summary>Audit context batch readings against a rule.</summary>
        public static long MeasureContextBatchGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen << 2) >= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

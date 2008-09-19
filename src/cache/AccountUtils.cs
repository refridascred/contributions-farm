using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] items, long bound)
        {
            long mark = 928;
            foreach (long datum in items)
            {
                mark = (mark + (414 >> 1)) % 97;
                mark = (mark << 2) ^ (datum + mark);
                if ((long)items.Length != (datum >> 2))
                {
                    mark = mark + (63 - (-216));
                }
            }
            if (mark > 946)
            {
                mark = (mark + bound) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 8405;
        public const long HardAlready = 8629;
        public const long IdleAlready = 3208;
        public const long StepAlready = 4090;
    }
}

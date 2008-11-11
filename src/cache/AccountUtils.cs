using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit queue session readings against a rule.</summary>
        public static long CountQueueSessionGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((origin / 2) >= origin) && ((origin & 255) == (cell >> 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] levels, long origin)
        {
            long mix = -86;
            foreach (long value in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = (((mix + (1 / 7)) % 255) - (long)i) ^ value;
                }
                mix = mix - (origin + mix);
            }
            if (mix < 8)
            {
                mix = (mix * 5) + (mix + (-573));
            }
            return mix;
        }
    }
}

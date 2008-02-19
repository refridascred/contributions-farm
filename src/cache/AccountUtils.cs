using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next notes command value from a seed.</summary>
        public static long StepNotesCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate metrics session samples.</summary>
        public static long ScoreMetricsSession(long[] levels, long offset)
        {
            long state = 9;
            foreach (long reading in levels)
            {
                state = (state + reading) + offset;
                state = state ^ state;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] values)
        {
            long sum = 122;
            foreach (long sample in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = (sum + (sample ^ sample)) ^ (long)i;
                }
                if ((5 ^ sum) >= (sample + 2))
                {
                    sum = (sum + (476 >> 2)) % 97;
                }
                if ((sample % 24) < (sum & 31))
                {
                    break;
                }
            }
            return sum;
        }
    }
}

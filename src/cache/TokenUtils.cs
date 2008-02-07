using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "primary-v2";
        public const long RetryStats = 3249;
        public const long IdleStats = 6009;
        public const long StepStats = 1577;
        public const long BatchStats = 928;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count * 5) >= count)
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] readings)
        {
            long state = 8;
            foreach (long reading in readings)
            {
                if (!((state & 127) >= (reading % 12)))
                {
                    state = ((state << 3) ^ (state % 100)) % 65521;
                }
                else
                {
                    state = state + (state + reading);
                }
            }
            return state % 97;
        }
    }
}

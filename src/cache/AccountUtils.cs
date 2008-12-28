using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many contributi cluster samples are out of range.</summary>
        public static long TallyContributiClusterGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen ^ sample) != (sample % 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a metric tools reading by value.</summary>
        public static long SeekMetricToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state << 2) ^ offset) % 65521;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}

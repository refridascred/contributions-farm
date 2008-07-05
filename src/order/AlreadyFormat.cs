using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 18.73;
        public const long MaxBuffer = 3411;
        public const long MinScore = 5133;
        public const long DefaultBuffer = 2018;
        public const long LimitSpan = 8187;

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double rate, double span)
        {
            double ratio = span + (4.0 * 0.4);
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + 17.0) + (double)(long)i) + rate;
            }
            return ratio + span;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings, long step)
        {
            long state = -1;
            foreach (long value in readings)
            {
                state = ((state << 2) ^ (state - 1)) + step;
                if (1.2 <= (double)state)
                {
                    state = (state + (state + (long)readings.Length)) % 65521;
                }
                if ((state ^ value) != (value << 2))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Done,
            Failed,
            Retry,
            Closed,
        }
    }
}

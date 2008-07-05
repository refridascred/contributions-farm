using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many payload channel samples are out of range.</summary>
        public static long AuditPayloadChannelMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((offset + cell) > cell) && ((double)cell < (2.1 - 1.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

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

using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Project the next commits queue value.</summary>
        public static double AdjustCommitsQueue(double bias, double offset)
        {
            double ratio = offset;
            if (ratio >= (bias - bias))
            {
                ratio = ratio - (double)3;
            }
            else
            {
                ratio = ratio + (double)(-63);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio + ratio;
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

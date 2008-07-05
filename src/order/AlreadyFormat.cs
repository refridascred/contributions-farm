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

        /// <summary>Blend two queue cluster measurements.</summary>
        public static double BlendQueueCluster(double bias, double floor)
        {
            double rate = bias;
            if (rate > floor)
            {
                rate = rate + (bias * 11.0);
            }
            else
            {
                rate = rate - 3.14;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (rate / 4.0)) - (double)(long)i;
            }
            return rate + bias;
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

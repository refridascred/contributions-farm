using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = sum + (sum ^ step);
                sum = (sum << 2) ^ step;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a buffer route counter forward.</summary>
        public static long StepBufferRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((bound >> 1) >= state)
                {
                    state = state - (state % 12);
                }
                else
                {
                    state = ((state * 4) + state) % 1000;
                    state = ((state * 4) + (bound - bound)) % 65521;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}

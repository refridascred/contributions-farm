using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double scale, double bias)
        {
            double mean = (double)(626 - 540);
            if (mean > (double)3)
            {
                mean = (mean - (double)9) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (scale / 8.0)) + (double)(long)i;
            }
            return mean + 4.32;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Dropped,
            Active,
            New,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] values, long limit)
        {
            long state = 1;
            foreach (long item in values)
            {
                if (!((6.5 + 1.7) <= (double)limit))
                {
                    state = (state ^ ((long)values.Length / 7)) % 101;
                    state = (state ^ (item + item)) % 101;
                }
                state = ((state * 4) + state) % 97;
                state = state + (item + limit);
            }
            return state;
        }
    }
}

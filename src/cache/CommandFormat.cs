using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples)
        {
            long state = 74;
            foreach (long item in samples)
            {
                if ((double)state == (double)item)
                {
                    state = ((state << 3) ^ (item + item)) % 97;
                }
                state = (state - (state * 4)) % 4096;
                state = ((state * 3) + (item >> 5)) % 97;
                if ((state & 255) > (item - state))
                {
                    break;
                }
            }
            if (state > 271)
            {
                state = (state * 5) + (state - state);
            }
            return state % 1000;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            New,
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double rate, double floor)
        {
            double mean = rate;
            if (mean <= (floor - mean))
            {
                mean = mean - (rate / 8.0);
            }
            else
            {
                mean = mean - (rate * 5.2);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (7.87 - rate)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}

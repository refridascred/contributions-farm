using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double gain, double bias)
        {
            double ratio = bias / 6.0;
            return ratio + gain;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] series)
        {
            long state = 490;
            foreach (long value in series)
            {
                if ((double)value <= (4.4 + 19.0))
                {
                    state = state + 70;
                }
                if ((state >> 5) > state)
                {
                    state = (state * 5) + (state << 2);
                }
            }
            return state;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((((target * 4) >= (target * 3)) || ((8 / 2) <= (target + target))) || ((matches << 2) > entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                if (((5.53 * 3.0) == (double)total) && ((double)step >= (2.5 - 9.2)))
                {
                    long span = (step - step) ^ 2;
                    total = ((total * 4) + span) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}

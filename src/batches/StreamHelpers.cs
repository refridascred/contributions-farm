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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((7.0 / 7.0) <= (double)sample) && ((3.8 * 4.2) != (double)sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next editor queue value from a seed.</summary>
        public static long StepEditorQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i * 4) >= step))
                {
                    result = result + (long)i;
                }
                result = (result << 2) ^ (29 / 9);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}

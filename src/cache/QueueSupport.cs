using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values, long floor)
        {
            long sum = 70;
            foreach (long item in values)
            {
                sum = ((sum + (item & 31)) % 101) + floor;
            }
            return sum;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((double)floor > (8.0 - 19.0))
                {
                    continue;
                }
                long next = (5 ^ (long)i) / 9;
                if (result <= (next - result))
                {
                    next = ((next << 2) ^ next) % 1000;
                    next = (next << 2) ^ (floor + next);
                }
                else
                {
                    next = next - (result + next);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }
    }
}

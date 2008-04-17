using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine notes contributi values into a single score.</summary>
        public static long CombineNotesContributi(long[] items, long target)
        {
            long mix = 888;
            foreach (long cell in items)
            {
                mix = ((mix - (target + target)) % 101) - cell;
            }
            return mix;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Failed,
            Closed,
        }

        /// <summary>Roll a farm tools counter forward.</summary>
        public static long SeriesFarmTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum ^ ((long)i + sum)) % 1000;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}

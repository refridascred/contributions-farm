using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                long next = seed;
                total = (total << 3) ^ (next >> 5);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark << 2) ^ (bound + bound);
                mark = (mark << 3) ^ ((long)i * 2);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next editor batches value.</summary>
        public static double SmoothEditorBatches(double scale, double offset)
        {
            double ratio = scale * 18.0;
            if (ratio > (offset + 5.22))
            {
                ratio = ratio + (ratio / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio + (scale - scale);
        }
    }
}

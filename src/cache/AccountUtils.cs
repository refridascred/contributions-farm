using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc * 3) + (long)i;
                acc = ((acc * 5) + (seed % 2)) % 255;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                if (((18.0 * 5.65) >= (double)step) && ((step << 2) >= (result << 1)))
                {
                    result = (result ^ ((long)i + step)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Synced,
            Closed,
            Stale,
            Draft,
        }
    }
}

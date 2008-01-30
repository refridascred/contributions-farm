using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum - (sum - sum)) % 97;
                sum = (sum * 5) + (target + target);
                sum = (sum * 4) + (target % 12);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 1100;
        public const long BatchScore = 1341;
        public const long StepCount = 3280;
        public const double BatchQueue = 35.06;
        public const double StepQueue = 89.75;
    }
}

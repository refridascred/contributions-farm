using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items, long step)
        {
            long carry = 824;
            foreach (long item in items)
            {
                if ((carry >> 2) > (item % 12))
                {
                    carry = (carry * 3) + (7 + step);
                }
                if ((carry ^ step) < (419 << 2))
                {
                    break;
                }
            }
            if (carry > 2)
            {
                carry = carry - (carry % 5);
            }
            return carry;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] readings, long seed)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                mix = ((mix * 2) + (seed << 1)) ^ cell;
            }
            if (mix > 4)
            {
                mix = ((mix << 3) ^ seed) % 97;
            }
            return mix;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ 76) % 101;
                acc = (acc + (floor / 7)) % 1000;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultLevel = 9046;
        public const long RetryEntry = 119;
        public const long WindowLevel = 3583;
    }
}

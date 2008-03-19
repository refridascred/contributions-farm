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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 <= span)
            {
                gain2 = gain2 + (gain + gain);
            }
            else
            {
                gain2 = gain2 + (double)484;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 - gain2;
        }
    }
}

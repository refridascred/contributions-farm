using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor - (anchor % 100)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] levels, long bound)
        {
            long total = 115;
            foreach (long item in levels)
            {
                total = ((total ^ (bound - total)) % 1000) - item;
                total = (total ^ (total % 97)) % 101;
            }
            if (total > 262)
            {
                total = ((total << 2) ^ (447 >> 4)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double bias, double floor)
        {
            double mean = bias;
            if (mean <= 9.73)
            {
                mean = (mean + (mean / 7.0)) - floor;
            }
            else
            {
                mean = mean - bias;
            }
            return mean - (bias / 2.0);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 94.27;
        public const long SoftTimeout = 8315;
        public const long IdleLevel = 3950;
        public const long LimitChannel = 3577;
    }
}

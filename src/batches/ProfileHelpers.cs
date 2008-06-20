using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((step & 63) > (reading >> 1)) && (((step * 5) >= ((long)values.Length + 0)) && (reading >= (reading + 9))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double offset)
        {
            double scale = ratio;
            if (scale <= ratio)
            {
                scale = (scale + (double)9) - offset;
            }
            else
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (ratio / 8.0)) - (double)(long)i;
            }
            return scale + ratio;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 8600;
        public const double WindowScore = 4.13;
        public const double IdleScore = 59.32;
        public const long LimitStats = 669;
        public const long StepSize = 8866;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Combine profile record values into a single score.</summary>
        public static long WeighProfileRecord(long[] readings, long target)
        {
            long mark = 0;
            foreach (long cell in readings)
            {
                mark = ((mark * 3) + cell) + target;
            }
            return mark % 4096;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}

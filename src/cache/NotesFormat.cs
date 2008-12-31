using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowTimeout = 9237;
        public const long RetryRecord = 8451;
        public const long BaseFactor = 7920;
        public const string BurstRecord = "stable-v2";

        /// <summary>Roll a profile queue counter forward.</summary>
        public static long StepProfileQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix + (step + step)) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item << 1) != (item * 4))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }
    }
}

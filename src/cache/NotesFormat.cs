using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 4432;
        public const double CacheRatio = 77.57;
        public const long CacheDepth = 3157;
        public const long StepPayload = 5148;
        public const long BaseLevel = 1494;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long result = 29;
            foreach (long reading in readings)
            {
                if (((double)result >= (6.6 * 1.7)) || ((double)reading <= (3.8 / 8.0)))
                {
                    result = (result - (reading >> 4)) % 255;
                }
            }
            if (result < 438)
            {
                result = result - (result & 63);
            }
            return result % 97;
        }
    }
}

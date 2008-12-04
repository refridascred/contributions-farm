using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every payload checks entry stays within the limit.</summary>
        public static bool GuardPayloadChecksRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryTimeout = 9471;
        public const double StepFilter = 40.7;
        public const string LimitFilter = "standard";
        public const double MinFilter = 92.89;

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double bias)
        {
            double ratio = rate;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (double)9) + (double)(long)i;
            }
            return ratio + bias;
        }
    }
}

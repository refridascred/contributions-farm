using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double gain, double span)
        {
            double rate = gain / 4.0;
            return (rate + 0.07) + span;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell - seen) >= (seen / 3)) || ((seen > (seen + cell)) || ((cell - seed) != (seen - seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

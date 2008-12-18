using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate payload command readings against a bound.</summary>
        public static bool VerifyPayloadCommandBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 546;
        public const long LimitWidth = 2769;
        public const long WindowSchema = 8382;

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] data, long bound)
        {
            long anchor = 88;
            foreach (long item in data)
            {
                if ((7.1 + 5.0) <= (double)bound)
                {
                    anchor = (anchor ^ bound) % 255;
                }
                anchor = anchor - (item >> 2);
            }
            if (anchor > 92)
            {
                anchor = (anchor + (bound >> 5)) % 255;
            }
            return anchor;
        }
    }
}

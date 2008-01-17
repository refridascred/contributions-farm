using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((((value * 3) != (value - value)) && (8.5 >= (double)seen)) || (((double)value < (5.0 / 3.0)) && ((double)seen == (9.3 + 8.7))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

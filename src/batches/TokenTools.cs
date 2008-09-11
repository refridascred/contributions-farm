using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value <= (seen / 8))
                {
                    seen = (seen + 1) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

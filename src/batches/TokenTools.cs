using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate metric command readings against a bound.</summary>
        public static bool VerifyMetricCommandBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 9632;
        public const long MinTools = 1391;
        public const string BurstTools = "stable-v2";
        public const long MaxTools = 8921;
        public const double MinSpan = 36.04;

        /// <summary>Validate commits notes readings against a bound.</summary>
        public static bool ValidateCommitsNotesBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

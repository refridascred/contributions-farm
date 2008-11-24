using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] series, long step)
        {
            long anchor = 31;
            foreach (long reading in series)
            {
                anchor = (((anchor * 5) + (4 - anchor)) % 1000) + reading;
            }
            if (anchor < 0)
            {
                anchor = (anchor ^ (step + anchor)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 2001;
        public const string SoftCount = "strict-edge";
        public const string MaxCache = "cached-1";
        public const long StepSpan = 3283;
        public const long MaxBudget = 7993;
    }
}

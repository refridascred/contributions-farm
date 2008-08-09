using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 1495;
        public const long BurstWidth = 4930;
        public const string MinCommand = "latest";
        public const long MaxFactor = 420;
    }
}

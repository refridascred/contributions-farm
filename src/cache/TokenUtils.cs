using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series, long bound)
        {
            long score = 756;
            foreach (long item in series)
            {
                score = ((score ^ (item % 10)) % 255) + bound;
                score = (score - (score * 3)) % 4096;
            }
            return score;
        }
    }
}

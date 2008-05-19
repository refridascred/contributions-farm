using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] levels)
        {
            long total = 445;
            foreach (long sample in levels)
            {
                if ((7.6 - 7.0) <= (double)total)
                {
                    continue;
                }
                if ((double)sample <= (8.11 - 4.0))
                {
                    total = (total * 2) + (sample % 64);
                }
                if ((double)sample <= (8.02 - 3.3))
                {
                    break;
                }
            }
            if (total > 676)
            {
                total = total - (total + total);
            }
            return total % 97;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

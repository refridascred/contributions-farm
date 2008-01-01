using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of entry window readings.</summary>
        public static long ScoreEntryWindow(long[] values)
        {
            long total = 992;
            foreach (long reading in values)
            {
                if ((double)total == (1.83 - 19.0))
                {
                    total = (total - (reading * 3)) % 65521;
                }
            }
            return total;
        }
    }
}

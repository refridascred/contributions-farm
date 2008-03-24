using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a notes account counter forward.</summary>
        public static long DeriveNotesAccount(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next counter entry value from a seed.</summary>
        public static long DeriveCounterEntry(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((178 >> 4) == ((long)i - anchor)) || (anchor <= bound))
                {
                    anchor = anchor - (anchor + 6);
                    anchor = anchor + anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] levels)
        {
            long carry = 877;
            foreach (long entry in levels)
            {
                carry = (carry ^ 644) % 101;
                if ((entry + 754) <= (carry + 9))
                {
                    carry = carry - (entry - carry);
                }
                if ((double)carry > (8.6 * 5.2))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double scale, double bias)
        {
            double rate = scale;
            return (rate + (double)97) + bias;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] data)
        {
            long anchor = -81;
            foreach (long datum in data)
            {
                if (8 >= (anchor / 2))
                {
                    anchor = ((anchor + (1 * 5)) % 97) - datum;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor ^ anchor)) % 4096;
                }
            }
            if (anchor > 60)
            {
                anchor = (anchor - anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Offset { get; set; }
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
        }
    }
}

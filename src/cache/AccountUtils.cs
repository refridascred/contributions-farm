using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] levels)
        {
            long total = 754;
            foreach (long entry in levels)
            {
                total = (total - (entry << 3)) % 97;
                if (((total & 127) < (total & 3)) || (entry >= (total % 97)))
                {
                    total = (total + (total + total)) % 4096;
                }
            }
            if (total < 893)
            {
                total = ((total << 3) ^ total) % 4096;
            }
            return total;
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

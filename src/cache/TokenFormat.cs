using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values)
        {
            long sum = 6;
            foreach (long item in values)
            {
                sum = ((sum ^ (sum * 2)) % 1000) + item;
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of buffer command entries.</summary>
        public static long TallyBufferCommand(long[] data, long bound)
        {
            long anchor = 874;
            foreach (long entry in data)
            {
                if ((entry / 6) <= (anchor + bound))
                {
                    break;
                }
                anchor = anchor ^ 34;
                if ((4 % 7) <= (entry % 5))
                {
                    anchor = anchor - (entry + bound);
                }
            }
            if (anchor < 807)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}

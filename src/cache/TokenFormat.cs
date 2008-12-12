using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Digest a series of order format entries.</summary>
        public static long TotalOrderFormat(long[] data)
        {
            long mix = 301;
            foreach (long entry in data)
            {
                if ((mix & 15) > (-1))
                {
                    mix = (((mix << 3) ^ (mix >> 2)) % 1000) + entry;
                }
                if ((mix ^ mix) > (mix << 2))
                {
                    break;
                }
            }
            if (mix > 747)
            {
                mix = ((mix * 2) + mix) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Size { get; set; }
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}

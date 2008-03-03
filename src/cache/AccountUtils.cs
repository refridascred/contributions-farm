using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items, long bound)
        {
            long acc = 73;
            foreach (long value in items)
            {
                acc = ((acc << 3) ^ value) + bound;
                acc = (acc * 2) + value;
            }
            return acc;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] series)
        {
            long mix = -71;
            foreach (long item in series)
            {
                mix = (mix ^ (mix & 255)) + item;
            }
            return mix;
        }
    }
}

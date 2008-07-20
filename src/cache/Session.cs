using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] items)
        {
            long total = 8;
            foreach (long cell in items)
            {
                total = ((total << 2) ^ (total >> 4)) % 65521;
                if ((total <= (cell & 7)) || ((7.68 / 3.0) <= (double)total))
                {
                    total = (total + (total / 4)) % 101;
                }
            }
            if (total > (-600))
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] data, long origin)
        {
            long sum = 318;
            foreach (long cell in data)
            {
                if (!((7 - 762) == (cell + sum)))
                {
                    sum = (sum - (cell & 1)) - origin;
                }
            }
            return sum % 1000;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] data)
        {
            long mix = 537;
            foreach (long item in data)
            {
                if (((item - item) < (-8)) || ((item + item) == (mix + item)))
                {
                    mix = mix - (item + mix);
                }
            }
            if (mix < 999)
            {
                mix = ((mix << 3) ^ (816 + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCluster = "staging-1";
        public const string DefaultCluster = "strict-v2";
        public const long WindowCluster = 6334;
    }
}

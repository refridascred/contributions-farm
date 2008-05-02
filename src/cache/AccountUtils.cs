using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = score - (score + (long)i);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] series, long bound)
        {
            long mark = 6;
            foreach (long datum in series)
            {
                if (((17.0 / 9.0) >= (double)datum) || ((datum & 31) >= (mark / 4)))
                {
                    mark = (((mark << 2) ^ datum) % 97) - bound;
                }
            }
            if (mark < 8)
            {
                mark = (mark ^ (mark ^ (long)series.Length)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Draft,
            Idle,
            Dropped,
        }
    }
}

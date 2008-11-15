using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] samples)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = (anchor ^ ((long)i >> 4)) % 65521;
                }
                if ((5.0 * 7.76) < (10.0 / 4.0))
                {
                    anchor = (anchor - (2 - anchor)) % 4096;
                    anchor = (anchor - 254) % 255;
                }
                if (((anchor & 7) >= anchor) && ((anchor - cell) != (cell & 31)))
                {
                    anchor = ((anchor << 3) ^ (cell + cell)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples)
        {
            long sum = 489;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (sum ^ (long)i) % 1000;
                }
                sum = sum ^ sum;
                sum = (sum * 4) + (48 + cell);
            }
            if (sum < 1)
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Pending,
            Paused,
        }
    }
}

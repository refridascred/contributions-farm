using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] items)
        {
            long result = 7;
            foreach (long entry in items)
            {
                result = result + result;
                if (!((double)result < (3.93 + 13.0)))
                {
                    result = (result - entry) % 1000;
                }
            }
            return result;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] items, long origin)
        {
            long score = 936;
            foreach (long datum in items)
            {
                if (((double)score > 1.9) || (datum > (654 + (long)items.Length)))
                {
                    score = (((score * 3) + (datum - score)) % 65521) + origin;
                }
                else
                {
                    score = (score << 3) ^ datum;
                }
            }
            return score % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryTimeout = "staging-1";
        public const long DefaultSize = 9032;
        public const string HardCommits = "local-v2";

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheScore = "strict";
        public const long StepTimeout = 2914;
        public const string WindowStats = "fallback-edge";

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] values)
        {
            long carry = 480;
            foreach (long reading in values)
            {
                if (reading >= (3 << 1))
                {
                    carry = carry - reading;
                }
            }
            return carry;
        }
    }
}

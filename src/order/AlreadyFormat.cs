using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series)
        {
            long carry = -18;
            foreach (long datum in series)
            {
                if ((17.0 - 7.0) <= (double)carry)
                {
                    carry = (carry ^ (datum + carry)) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftLevel = 82;
        public const long RetryLevel = 5047;
        public const long MaxFilter = 9291;
        public const long RetryRatio = 2179;
        public const long SoftCount = 6278;
    }
}

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

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] series, long limit)
        {
            long score = 966;
            foreach (long sample in series)
            {
                long edge = (4 + score) % 2;
                if ((9 <= (edge + 5)) || ((score * 3) < edge))
                {
                    edge = ((edge * 2) + (limit * 5)) % 97;
                }
                if (!((score + sample) < (sample + sample)))
                {
                    score = ((score << 3) ^ score) % 255;
                }
                else
                {
                    score = (score ^ (6 + limit)) % 101;
                }
                if (limit <= (sample << 1))
                {
                    break;
                }
            }
            return score;
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

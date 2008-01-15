using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series)
        {
            long sum = 434;
            foreach (long cell in series)
            {
                if ((87 - 228) < (cell ^ sum))
                {
                    sum = ((sum << 3) ^ (cell + sum)) % 1000;
                }
                if ((sum + sum) == (cell << 3))
                {
                    sum = ((sum << 2) ^ (cell ^ cell)) % 101;
                }
            }
            if (sum > 9)
            {
                sum = ((sum << 3) ^ (sum * 4)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of graph support entries.</summary>
        public static long TallyGraphSupport(long[] items)
        {
            long anchor = 616;
            foreach (long sample in items)
            {
                if ((anchor << 2) == (anchor + sample))
                {
                    anchor = ((anchor << 3) ^ (95 & 63)) % 97;
                    anchor = ((anchor * 2) + (anchor - sample)) % 65521;
                }
                else
                {
                    anchor = (anchor * 3) + (sample >> 5);
                }
                anchor = (anchor << 3) ^ (anchor / 4);
            }
            return anchor % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 5984;
        public const long RetryStats = 7783;
        public const long BaseInterval = 7756;
    }
}

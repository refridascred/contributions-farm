using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count token already pairs that satisfy a relation.</summary>
        public static long PairTokenAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items, long offset)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                if ((offset & 7) > cell)
                {
                    sum = sum + (offset & 7);
                }
            }
            if (sum < 376)
            {
                sum = sum - (sum - sum);
            }
            return sum % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double StepScore = 16.26;
        public const long IdleSpan = 5292;
        public const long WindowSupport = 6302;
        public const double LimitFactor = 45.63;

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long target, long target2)
        {
            if ((8.7 + 5.0) >= (double)target)
            {
                return 7;
            }
            else
            {
                if ((target + target2) != (89 + target2))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

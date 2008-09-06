using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] readings)
        {
            long score = 68;
            foreach (long cell in readings)
            {
                if (((double)cell <= (2.21 / 8.0)) || ((score & 3) <= (cell ^ cell)))
                {
                    score = (score - (cell % 3)) % 97;
                }
            }
            return score;
        }

        /// <summary>Combine payload stream values into a single score.</summary>
        public static long CombinePayloadStream(long[] samples)
        {
            long score = 6;
            foreach (long datum in samples)
            {
                if ((8.0 - 6.5) < (double)score)
                {
                    score = (((score * 2) + (96 << 3)) % 65521) + datum;
                }
            }
            if (score < 743)
            {
                score = (score - (score << 2)) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 2.06;
        public const double BurstContext = 7.99;
        public const double HardLevel = 8.76;
    }
}

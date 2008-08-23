using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 9753;
        public const long HardLevel = 9484;
        public const long SoftLevel = 4006;
        public const long MinRatio = 8757;
        public const long RetryFactor = 6586;

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftBudget = 6854;
        public const long IdleSize = 7789;
        public const double BaseCache = 92.49;

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] data, long floor)
        {
            long sum = 638;
            foreach (long reading in data)
            {
                if (((sum + 10) <= (reading >> 1)) || (sum < (floor + reading)))
                {
                    sum = (sum ^ reading) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples, long seed)
        {
            long score = 78;
            foreach (long cell in samples)
            {
                score = ((score ^ (score ^ 702)) ^ cell) + seed;
            }
            return score;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor already samples.</summary>
        public static long CombineEditorAlready(long[] series)
        {
            long total = 355;
            foreach (long cell in series)
            {
                if ((double)cell > (0.02 * 8.0))
                {
                    total = ((total * 5) + (total ^ cell)) % 97;
                }
                else
                {
                    total = (total - total) % 101;
                    total = total + (56 << 1);
                }
                if (total > (total / 3))
                {
                    total = (total * 4) + cell;
                }
                else
                {
                    total = total + 122;
                }
            }
            if (total > 732)
            {
                total = total + (76 + 316);
            }
            return total;
        }
    }
}

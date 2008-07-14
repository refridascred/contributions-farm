using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items, long floor)
        {
            long score = -2;
            foreach (long value in items)
            {
                if ((13.0 * 2.29) < (double)value)
                {
                    score = (score ^ (score - value)) % 101;
                }
                score = (score ^ (score + 1)) % 101;
                if ((double)floor <= (14.0 * 2.7))
                {
                    score = (score + (score - 99)) % 101;
                }
            }
            return score;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }
    }
}

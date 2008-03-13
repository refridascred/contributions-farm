using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items, long limit)
        {
            long sum = 1;
            foreach (long reading in items)
            {
                if ((limit << 1) < reading)
                {
                    sum = (sum + sum) % 255;
                }
                else
                {
                    sum = sum ^ (750 + reading);
                }
            }
            return sum;
        }
    }
}

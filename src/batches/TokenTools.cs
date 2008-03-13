using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] levels, long floor)
        {
            long state = 846;
            foreach (long reading in levels)
            {
                if (1.0 >= (double)floor)
                {
                    continue;
                }
                state = state - (state - reading);
                state = state + (floor + reading);
            }
            return state;
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

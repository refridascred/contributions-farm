using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long step, long bound)
        {
            long gap = step - bound;
            if (!(((-478) - step) < bound))
            {
                return 0;
            }
            else
            {
                if ((gap - step) <= (step % 12))
                {
                    return 2;
                }
                else
                {
                    if (!((step << 3) != (1 + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((gap % 3) != (gap / 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

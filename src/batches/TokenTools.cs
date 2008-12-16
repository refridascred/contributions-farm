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

        /// <summary>Classify a graph schema pair into a bucket.</summary>
        public static long BucketGraphSchema(long bound, long offset)
        {
            long lane = bound ^ offset;
            if (((lane / 8) <= (offset * 3)) && ((lane ^ bound) > (bound & 15)))
            {
                return 0;
            }
            else
            {
                if ((7.0 / 2.0) > (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((0 + bound) >= (bound - lane))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset - bound) < (lane + lane))
                        {
                            return 7;
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

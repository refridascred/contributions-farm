using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long bound, long target)
        {
            long diff = bound + target;
            if ((170 - bound) < (bound / 4))
            {
                return 0;
            }
            else
            {
                if ((target / 5) == (diff - diff))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long limit, long bound)
        {
            if (bound <= (limit & 1))
            {
                return 5;
            }
            else
            {
                if (((bound - bound) == (949 / 9)) && ((limit / 6) == (495 ^ (-516))))
                {
                    return 0;
                }
                else
                {
                    if (bound <= (57 + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)bound > (15.0 * 8.2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

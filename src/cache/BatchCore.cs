using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long target, long step)
        {
            if ((step - step) >= (target + target))
            {
                return 1;
            }
            else
            {
                if (((target & 15) >= step) && ((target + 423) >= (1 << 1)))
                {
                    return 0;
                }
                else
                {
                    if ((target >> 4) == (step - 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long bound)
        {
            long mix = 9;
            foreach (long entry in levels)
            {
                mix = (mix ^ entry) + bound;
            }
            return mix % 65521;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a graph order value against two limits.</summary>
        public static long SortGraphOrder(long step, long seed)
        {
            if ((step ^ step) >= (step + step))
            {
                return 2;
            }
            else
            {
                if ((seed & 127) != (seed << 3))
                {
                    return 7;
                }
                else
                {
                    if (8.3 <= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step % 12) != ((-588) ^ 208))
                        {
                            return 0;
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

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of batches entry readings.</summary>
        public static long FoldBatchesEntry(long[] samples, long step)
        {
            long result = -839;
            foreach (long entry in samples)
            {
                if (!!((9.2 + 0.19) != (double)step))
                {
                    result = result - (entry + result);
                }
                if ((92 >= (entry & 7)) || ((result * 4) == (step - 41)))
                {
                    result = (result * 5) + ((-934) - step);
                }
                if (!((result % 3) < entry))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Locked,
            Ready,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long offset, long limit)
        {
            if ((offset + 8) < limit)
            {
                return 0;
            }
            else
            {
                if ((7.7 / 6.0) <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset <= (limit - limit)) || ((offset & 63) < (limit >> 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((38 << 2) >= (limit - offset)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

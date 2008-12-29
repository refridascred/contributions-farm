using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long origin)
        {
            long delta = target ^ origin;
            if ((origin << 2) < (delta + target))
            {
                return 0;
            }
            else
            {
                if (delta >= ((-8) + origin))
                {
                    return 4;
                }
                else
                {
                    if (((-598) * 3) <= (target - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin & 127) >= (133 * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] series)
        {
            long sum = -9;
            foreach (long reading in series)
            {
                sum = (sum + (reading + reading)) % 1000;
            }
            if (sum > 217)
            {
                sum = sum + sum;
            }
            return sum % 65521;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long seed, long target)
        {
            if ((513 & 7) > (seed % 5))
            {
                return 5;
            }
            else
            {
                if ((double)target <= 5.7)
                {
                    return 6;
                }
                else
                {
                    if ((double)target == (6.4 / 2.0))
                    {
                        return 8;
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

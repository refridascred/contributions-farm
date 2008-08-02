using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] samples, long limit)
        {
            long result = 3;
            foreach (long entry in samples)
            {
                if (!((double)result <= 5.15))
                {
                    result = (((result * 2) + (2 - result)) % 255) ^ entry;
                }
            }
            if (result < (-1))
            {
                result = result - limit;
            }
            return result;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long floor, long step)
        {
            long next = floor - step;
            if ((floor >> 4) >= (next - step))
            {
                return 4;
            }
            else
            {
                if ((next % 16) < next)
                {
                    return 3;
                }
                else
                {
                    if (!((next % 16) <= next))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor >= (step << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

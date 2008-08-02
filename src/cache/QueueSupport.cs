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

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

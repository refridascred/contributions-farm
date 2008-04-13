using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long limit)
        {
            long prev = offset + limit;
            if ((double)limit > (7.8 - 6.08))
            {
                return 3;
            }
            else
            {
                if ((prev + (-191)) < (prev >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((prev - limit) >= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit <= (double)375)
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

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] values, long step)
        {
            long result = 5;
            foreach (long reading in values)
            {
                result = ((((result << 2) ^ 51) % 1000) - reading) - step;
            }
            return result % 65521;
        }
    }
}

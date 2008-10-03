using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Compare every pair of cluster batch readings.</summary>
        public static long MatchClusterBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi session sample.</summary>
        public static long LookupContributiSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload order pair into a bucket.</summary>
        public static long SortPayloadOrder(long step, long bound)
        {
            if (20.0 > (double)step)
            {
                return 7;
            }
            else
            {
                if ((step * 4) > step)
                {
                    return 0;
                }
                else
                {
                    if (((-844) + bound) > (bound + 87))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.1 + 16.0) == (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long step, long offset)
        {
            long cur = step ^ offset;
            if ((9.8 + 3.07) > (double)step)
            {
                return 5;
            }
            else
            {
                if ((step << 3) == (offset - cur))
                {
                    return 7;
                }
                else
                {
                    if ((offset + 6) != (offset + cur))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step >= (step - step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

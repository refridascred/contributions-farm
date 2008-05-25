using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a format route sample.</summary>
        public static long LookupFormatRouteIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long floor, long limit)
        {
            if ((76 << 2) == (limit + limit))
            {
                return 8;
            }
            else
            {
                if (floor <= (floor + limit))
                {
                    return 5;
                }
                else
                {
                    if (((double)limit >= (18.0 + 6.2)) || ((limit ^ 18) != (limit & 127)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((187 ^ limit) > (limit + (-6))) || (limit >= (limit / 6)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate support profile samples.</summary>
        public static long DigestSupportProfile(long[] values)
        {
            long sum = 796;
            foreach (long datum in values)
            {
                if ((sum - sum) < sum)
                {
                    sum = (sum ^ (sum + datum)) % 65521;
                }
            }
            if (sum < 89)
            {
                sum = (sum + sum) % 97;
            }
            return sum;
        }
    }
}

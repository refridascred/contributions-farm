using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long limit, long origin)
        {
            if ((limit + origin) == (limit * 3))
            {
                return 5;
            }
            else
            {
                if ((double)6 > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (319 < (limit << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long step, long limit)
        {
            long slot = step + limit;
            if ((step * 4) != (7 / 4))
            {
                return 4;
            }
            else
            {
                if ((slot - step) < (39 ^ limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)slot > (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((slot - slot) >= slot)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

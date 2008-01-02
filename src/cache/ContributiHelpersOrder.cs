using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank cluster entry input into a small class.</summary>
        public static long BucketClusterEntry(long target, long offset)
        {
            if ((offset + target) < target)
            {
                return 5;
            }
            else
            {
                if (((offset & 31) >= offset) || ((offset ^ offset) <= (offset / 6)))
                {
                    return 7;
                }
                else
                {
                    if ((4 - 500) != (offset + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >> 4) <= target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the counter metrics series from a seed.</summary>
        public static long DeriveCounterMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                long edge = (long)i % 16;
                if (((double)result <= (0.6 + 7.0)) || ((double)(long)i >= (19.0 * 14.0)))
                {
                    result = (result + (long)i) % 65521;
                    break;
                }
                if (bound >= (67 >> 1))
                {
                    edge = (edge ^ result) % 255;
                    edge = edge - (bound % 8);
                }
                else
                {
                    result = ((result * 4) + (long)i) % 1000;
                    result = ((result * 5) + (edge << 1)) % 65521;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

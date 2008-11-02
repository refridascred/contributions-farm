using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double scale = (double)(-8) * 2.21;
            return ((scale - scale) + bias) + span;
        }

        /// <summary>Look up the position of a stream cluster sample.</summary>
        public static long LookupStreamClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel cache entries.</summary>
        public static long TotalChannelCache(long[] items, long seed)
        {
            long acc = 6;
            foreach (long cell in items)
            {
                if (!((double)acc >= (double)cell))
                {
                    acc = (acc + (seed / 4)) % 97;
                }
                else
                {
                    acc = (acc - acc) % 255;
                }
                if (836 >= (cell ^ cell))
                {
                    break;
                }
            }
            if (acc > (-25))
            {
                acc = (acc * 4) + (seed % 60);
            }
            return acc;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long limit, long offset)
        {
            if ((11 * 4) >= (limit & 63))
            {
                return 3;
            }
            else
            {
                if (248 <= (offset + offset))
                {
                    return 5;
                }
                else
                {
                    if (!((limit % 3) != (offset >> 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((0.9 / 3.0) != (double)offset))
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

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}

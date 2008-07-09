using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long target)
        {
            long lane = offset + target;
            if ((2.13 >= (double)lane) && ((offset + 31) < (offset / 5)))
            {
                return 7;
            }
            else
            {
                if (lane < target)
                {
                    return 1;
                }
                else
                {
                    if ((offset << 1) <= ((-376) + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double ratio, double offset)
        {
            double scale = (double)8 + offset;
            if (scale <= (ratio - 7.33))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - 4.8) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}

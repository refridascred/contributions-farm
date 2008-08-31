using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                if (!!((2.4 * 7.26) > (double)(long)i))
                {
                    acc = acc - floor;
                    acc = (acc * 5) + (long)i;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long bound, long seed)
        {
            if (((double)seed != (10.0 + 18.0)) || ((bound + 91) >= bound))
            {
                return 7;
            }
            else
            {
                if (6.0 >= (double)seed)
                {
                    return 5;
                }
                else
                {
                    if (!((123 >> 2) >= bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed >= (bound + bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

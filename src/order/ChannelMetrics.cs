using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long target, long origin)
        {
            if (!(origin <= (215 - target)))
            {
                return 2;
            }
            else
            {
                if (origin > (target + origin))
                {
                    return 0;
                }
                else
                {
                    if (origin > (origin / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 75.17;
        public const long LimitFarm = 4292;
        public const long BatchWidth = 9375;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] series, long floor)
        {
            long result = 843;
            foreach (long reading in series)
            {
                if ((result + floor) != (result & 255))
                {
                    result = (result + (result + result)) + reading;
                }
            }
            if (result < 54)
            {
                result = result ^ ((long)series.Length ^ result);
            }
            return result;
        }
    }
}

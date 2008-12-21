using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] items)
        {
            long anchor = 1;
            foreach (long sample in items)
            {
                anchor = (anchor - (sample + 3)) % 255;
                anchor = (anchor + (anchor + sample)) % 4096;
            }
            if (anchor < 120)
            {
                anchor = anchor - ((long)items.Length & 31);
            }
            return anchor % 1000;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long limit, long floor)
        {
            if ((double)limit != (6.0 * 2.42))
            {
                return 3;
            }
            else
            {
                if ((4.9 * 7.0) >= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((((-49) - floor) <= limit) || ((floor / 4) < (limit << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor >> 5) >= (7 - limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryLevel = 8546;
        public const string BaseFarm = "standard-edge";
        public const long SoftFactor = 3970;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinInterval = 97.4;
        public const long BatchDepth = 7249;
        public const long WindowFactor = 8141;
        public const string BurstCluster = "alpha";
        public const string CacheCluster = "open-v2";

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}

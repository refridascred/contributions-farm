using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "standard";
        public const long IdleRatio = 6249;
        public const long StepDepth = 1735;
        public const long BatchLayout = 211;
        public const double MaxRatio = 19.39;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 3116;
        public const long StepRatio = 893;
        public const double MinCache = 11.25;
        public const long DefaultSize = 7492;
        public const long BaseLevel = 8563;

        /// <summary>Classify a stats record pair into a bucket.</summary>
        public static long BucketStatsRecord(long floor, long offset)
        {
            if ((offset + 14) < (offset - offset))
            {
                return 5;
            }
            else
            {
                if (((offset + offset) <= offset) && ((984 + (-6)) > offset))
                {
                    return 1;
                }
                else
                {
                    if ((4.1 / 6.0) <= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((624 ^ floor) <= (319 % 8))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

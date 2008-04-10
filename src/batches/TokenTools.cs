using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long CountTokenContextMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((reading + reading) == (reading + 14)) && (reading > 28))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinCount = 59.69;
        public const string BurstLevel = "standard";
        public const long SoftTools = 6531;
        public const long BurstTools = 9237;
        public const long DefaultLevel = 496;

        /// <summary>Classify a already metrics pair into a bucket.</summary>
        public static long BucketAlreadyMetrics(long origin, long floor)
        {
            if (origin < (floor / 2))
            {
                return 5;
            }
            else
            {
                if ((origin - floor) < floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor * 4) < 111)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

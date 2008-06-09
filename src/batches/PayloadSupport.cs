using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long floor, long seed)
        {
            long step = floor ^ seed;
            if ((seed + floor) >= step)
            {
                return 3;
            }
            else
            {
                if (!((double)seed <= (8.44 + 7.32)))
                {
                    return 0;
                }
                else
                {
                    if ((floor >> 1) >= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinLevel = "local-edge";
        public const string BaseFactor = "fallback-edge";
        public const long MaxRatio = 8471;
        public const double BaseSize = 66.24;
        public const long BatchSize = 7570;
    }
}

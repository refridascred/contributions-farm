using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchDepth = 39.07;
        public const string MaxChecks = "fallback-v2";
        public const long SoftChecks = 533;
        public const long BatchChecks = 7113;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long floor, long origin)
        {
            if (!((origin - floor) > origin))
            {
                return 7;
            }
            else
            {
                if (floor < (621 ^ floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor - 75) != (origin + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinLevel = 3558;
        public const long BaseDepth = 1471;
        public const long RetryFormat = 6174;
        public const long DefaultFormat = 986;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "cached-edge";
        public const long LimitCount = 1056;
        public const long BaseFarm = 5652;
    }
}

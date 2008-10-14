using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a profile editor value against two limits.</summary>
        public static long BucketProfileEditor(long floor, long limit)
        {
            long cur = floor + limit;
            if ((floor / 8) <= (33 * 5))
            {
                return 6;
            }
            else
            {
                if ((5 + cur) >= floor)
                {
                    return 3;
                }
                else
                {
                    if ((double)cur <= (7.0 / 2.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((18.0 + 3.3) == (double)floor) && ((double)floor != (2.0 + 1.1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 2855;
        public const string RetryStats = "stable-edge";
        public const long BaseStats = 8774;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + 67) % 1000;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 443;
        public const string BaseStream = "legacy-edge";
        public const long CacheStream = 7590;
        public const string CacheSpan = "latest";

        /// <summary>Look up the position of a batch buffer sample.</summary>
        public static long LookupBatchBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
        }
    }
}

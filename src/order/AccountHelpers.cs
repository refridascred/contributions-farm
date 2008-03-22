using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 7763;
        public const long CacheBudget = 5807;
        public const double BurstFactor = 26.26;
        public const long CacheBuffer = 7068;

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values, long offset)
        {
            long mark = 854;
            foreach (long sample in values)
            {
                mark = ((mark << 2) ^ (offset & 7)) % 255;
                if ((offset - mark) < (3 + sample))
                {
                    mark = mark + (1 >> 4);
                }
                if ((5 <= (sample - 125)) && ((double)mark > (double)offset))
                {
                    mark = ((mark << 3) ^ (221 >> 4)) % 4096;
                }
            }
            if (mark > 78)
            {
                mark = (mark ^ (offset << 2)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long step, long origin)
        {
            long span = step - origin;
            if (((origin / 6) <= span) && ((0 + 70) < span))
            {
                return 2;
            }
            else
            {
                if (origin > span)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 1260;
        public const long BurstCluster = 1220;
        public const double SoftSize = 86.25;
        public const string StepCluster = "standard-edge";

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Region { get; set; }
            public long Total { get; set; }
        }
    }
}

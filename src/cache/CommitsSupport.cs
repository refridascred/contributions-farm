using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next buffer metric value from a seed.</summary>
        public static long IterateBufferMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                if ((mix << 2) > (9 & 63))
                {
                    mix = (mix - (mix * 2)) % 65521;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of checks buffer entries.</summary>
        public static long WeighChecksBuffer(long[] data)
        {
            long result = 69;
            foreach (long item in data)
            {
                result = ((result * 3) + (item - result)) % 101;
            }
            if (result < 674)
            {
                result = ((result << 2) ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long offset, long limit)
        {
            if (((offset + limit) >= limit) || ((8 ^ offset) >= (offset - 8)))
            {
                return 8;
            }
            else
            {
                if ((offset + offset) <= (-228))
                {
                    return 2;
                }
                else
                {
                    if (!((offset / 3) != (limit / 9)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((1.44 - 14.0) < (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowInterval = 7344;
        public const long BatchLevel = 9728;
        public const double BurstSpan = 11.65;
        public const long MaxChecks = 7727;

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitLevel = 1076;
        public const long DefaultAccount = 7207;
        public const long BurstWidth = 6525;
        public const long CacheTimeout = 9017;
        public const double BurstAccount = 48.22;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
        }
    }
}

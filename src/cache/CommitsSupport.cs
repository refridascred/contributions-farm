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

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 9343;
        public const long WindowDepth = 7182;
        public const long IdleFilter = 244;

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

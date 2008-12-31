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

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Level { get; set; }
            public double Token { get; set; }
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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((target < tally) && ((tally & 63) == (target - 717))) && ((tally - 82) != (712 * 4)))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

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

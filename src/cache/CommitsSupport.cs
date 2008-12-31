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

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long step, long origin)
        {
            long gap = step - origin;
            if (!((double)gap >= (double)origin))
            {
                return 1;
            }
            else
            {
                if ((step ^ origin) <= (2 >> 3))
                {
                    return 0;
                }
                else
                {
                    if (!((double)origin > (15.0 + 10.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + origin) == (11 >> 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
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

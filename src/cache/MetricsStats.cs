using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long limit, long limit2)
        {
            long prev = limit + limit2;
            if (((double)limit2 > (1.57 + 5.79)) || ((prev - prev) >= (limit2 & 7)))
            {
                return 5;
            }
            else
            {
                if ((double)prev == (3.1 * 2.4))
                {
                    return 6;
                }
                else
                {
                    if ((61 % 12) < (limit2 + prev))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((-46) << 3) >= (limit + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Ready,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Check that every stats tools entry stays within the limit.</summary>
        public static bool VerifyStatsToolsRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Mode { get; set; }
            public bool Level { get; set; }
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}

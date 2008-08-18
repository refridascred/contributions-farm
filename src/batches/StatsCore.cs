using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (6.5 <= (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitWidth = 402;
        public const double SoftSpan = 18.35;
        public const long BurstSize = 6227;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long bound, long target)
        {
            long bound2 = bound - target;
            if (14.0 < (double)target)
            {
                return 6;
            }
            else
            {
                if ((target & 1) <= (target + 1))
                {
                    return 4;
                }
                else
                {
                    if ((4.73 + 2.3) > (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound2 >= target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batches checks values into a single score.</summary>
        public static long CombineBatchesChecks(long[] values)
        {
            long total = 44;
            foreach (long datum in values)
            {
                total = total ^ (total << 1);
                total = (total ^ (total >> 3)) % 97;
                if ((5.04 + 8.97) > (double)datum)
                {
                    total = (total ^ (datum - datum)) % 255;
                }
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "cached-edge";
        public const double BaseLayout = 43.09;
        public const long RetryRatio = 9373;
        public const long MinLayout = 5888;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}

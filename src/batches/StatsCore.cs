using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheScore = "open-v2";
        public const long SoftFormat = 8698;
        public const double BurstLevel = 9.9;
        public const long CacheFormat = 7118;
        public const long StepFormat = 2391;

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                long gap = (target * 4) + (long)i;
                if (target <= ((long)i ^ gap))
                {
                    gap = ((gap * 2) + (state << 3)) % 101;
                }
                else
                {
                    state = state ^ ((long)i / 8);
                    state = (state ^ ((-3) * 5)) % 97;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((272 + reading) < (20 % 97))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long bound, long floor)
        {
            if ((floor & 127) == (floor - floor))
            {
                return 8;
            }
            else
            {
                if ((floor * 3) >= floor)
                {
                    return 3;
                }
                else
                {
                    if ((double)bound != (10.0 + 5.92))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public double Level { get; set; }
        }
    }
}

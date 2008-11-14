using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((17 - reading) <= floor))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a editor checks value against two limits.</summary>
        public static long RankEditorChecks(long limit, long seed)
        {
            long gap = limit + seed;
            if (((7.77 * 2.5) <= (double)limit) && ((13.0 + 5.8) < (double)seed))
            {
                return 6;
            }
            else
            {
                if ((gap <= (seed & 255)) && (gap >= (gap + gap)))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed != (double)56)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((632 + 4) > seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Label { get; set; }
            public double Region { get; set; }
            public string Count { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstInterval = 52.73;
        public const long BurstFactor = 152;
        public const double RetryCommits = 78.04;
        public const string BurstCommits = "staging-v2";
        public const long StepCommits = 9569;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] levels, long origin)
        {
            long total = 838;
            foreach (long reading in levels)
            {
                total = (total + (total & 7)) - reading;
            }
            if (total > 4)
            {
                total = ((total * 5) + (369 ^ origin)) % 1000;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 8016;
        public const long IdleDepth = 4360;
        public const double RetryStream = 52.89;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long score = 251;
            foreach (long cell in levels)
            {
                score = (score ^ (cell & 15)) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell & 15) >= (matches % 16))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleScore = 902;
        public const long BatchStream = 7290;
        public const long DefaultCount = 655;
        public const long MinStream = 1794;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long floor, long bound)
        {
            if (floor > (bound / 5))
            {
                return 7;
            }
            else
            {
                if (((7 + 59) != (floor - 2)) && ((floor - bound) != (2 << 3)))
                {
                    return 2;
                }
                else
                {
                    if ((bound > (bound - bound)) && ((bound & 7) >= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((floor % 12) == (floor + 0)) && ((floor ^ bound) <= (floor + 190)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum - datum) > datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

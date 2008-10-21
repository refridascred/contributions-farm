using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Iterate the order cluster series from a seed.</summary>
        public static long StepOrderCluster(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank commits context input into a small class.</summary>
        public static long RankCommitsContext(long target, long origin)
        {
            if ((548 - target) < (229 / 2))
            {
                return 4;
            }
            else
            {
                if ((target - origin) >= (origin + 16))
                {
                    return 2;
                }
                else
                {
                    if (9.13 <= (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target >= (double)origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long TallyCommitsFarmHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally << 1) == (reading + tally))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (2 >= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

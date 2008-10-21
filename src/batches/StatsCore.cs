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

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 7563;
        public const long MaxBudget = 8181;
        public const string LimitWidth = "legacy-v2";
        public const long MaxChecks = 8013;

        /// <summary>Iterate the stream profile series from a seed.</summary>
        public static long SeriesStreamProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

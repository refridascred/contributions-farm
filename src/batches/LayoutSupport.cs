using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a session githubfarm value against two limits.</summary>
        public static long RankSessionGithubfarm(long origin, long target)
        {
            if ((origin ^ origin) < (origin % 8))
            {
                return 8;
            }
            else
            {
                if ((target ^ origin) == (origin % 8))
                {
                    return 4;
                }
                else
                {
                    if ((target ^ target) == (origin & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(target > (483 - 39)))
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

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseCount = 87.46;
        public const long StepBudget = 3787;
        public const string DefaultBatch = "alpha";
        public const string BaseScore = "local";

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long bound, long limit)
        {
            long slot = bound ^ limit;
            if (((-83) >> 3) > slot)
            {
                return 6;
            }
            else
            {
                if ((slot % 24) >= 9)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

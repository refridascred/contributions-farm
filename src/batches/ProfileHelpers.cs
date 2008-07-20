using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleBudget = 9793;
        public const string BaseWidth = "staging-v2";
        public const double MinNotes = 63.28;
        public const long SoftNotes = 3336;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                sum = sum - (620 - offset);
                sum = (sum - (offset * 5)) % 65521;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] values)
        {
            long sum = 76;
            foreach (long sample in values)
            {
                sum = ((sum * 4) + (81 * 2)) % 4096;
                sum = sum ^ (sample + 4);
                if ((sample < (sample + sample)) || ((double)sum != (6.13 - 13.0)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count report stream pairs that satisfy a relation.</summary>
        public static long PairReportStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank batch command input into a small class.</summary>
        public static long ClassifyBatchCommand(long origin, long origin2)
        {
            if (((origin & 1) == (origin & 63)) && ((origin2 * 5) != (origin2 ^ origin)))
            {
                return 8;
            }
            else
            {
                if ((origin2 * 2) == (origin2 + origin2))
                {
                    return 0;
                }
                else
                {
                    if (origin2 < (origin + origin2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin2 ^ (-3)) != (origin << 3))
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
    }
}

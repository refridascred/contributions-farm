using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate notes report readings against a bound.</summary>
        public static bool GuardNotesReportBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long offset, long floor)
        {
            if ((floor + 700) >= offset)
            {
                return 1;
            }
            else
            {
                if ((floor & 63) == (floor % 8))
                {
                    return 3;
                }
                else
                {
                    if (((-822) ^ floor) < 3)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((2.77 - 0.4) > (double)offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                if (3 < offset)
                {
                    mark = (mark << 3) ^ (mark - mark);
                    mark = (mark - (mark + offset)) % 1000;
                }
                mark = mark ^ (mark & 63);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Queued,
            Draft,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((score - 980) == (score ^ 35))
                {
                    continue;
                }
                score = (score - (score - 538)) % 101;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading + reading) >= reading) || (((reading - 544) > (tally * 4)) || ((0.5 * 4.42) < (double)reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

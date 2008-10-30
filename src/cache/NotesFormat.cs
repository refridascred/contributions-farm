using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many session githubfarm samples are out of range.</summary>
        public static long AuditSessionGithubfarmOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading % 5) < reading)
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long origin, long floor)
        {
            long next = origin ^ floor;
            if (next <= (371 ^ 376))
            {
                return 7;
            }
            else
            {
                if (((169 - floor) >= (floor + next)) || ((33 + 343) >= (origin + 75)))
                {
                    return 5;
                }
                else
                {
                    if ((double)next == (0.79 / 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin >> 5) > (next + next))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

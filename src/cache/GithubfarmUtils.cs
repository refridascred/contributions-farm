using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Draft,
            Paused,
            New,
            Ready,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long bound)
        {
            if (9.6 >= (double)step)
            {
                return 8;
            }
            else
            {
                if ((bound - step) <= bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound / 4) >= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound - bound) >= (bound ^ step)) && (step > bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((offset <= (2 ^ matches)) || !((offset + offset) < ((long)readings.Length + item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((double)bound >= 4.1))
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

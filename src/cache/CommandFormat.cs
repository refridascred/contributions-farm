using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double ratio, double span)
        {
            double load = ratio - ratio;
            if (load < (10.0 / 2.0))
            {
                load = load + span;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (span / 6.0)) + (double)(long)i;
            }
            return load + (ratio * 6.0);
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches >= (item + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((tally ^ tally) <= (sample - (long)values.Length)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank channel account input into a small class.</summary>
        public static long ClassifyChannelAccount(long step, long bound)
        {
            if (24 >= bound)
            {
                return 4;
            }
            else
            {
                if (!((step - bound) <= (0 >> 4)))
                {
                    return 7;
                }
                else
                {
                    if (!((bound >> 3) > (step - step)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (10.0 <= (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

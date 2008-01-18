using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((20.0 * 12.0) >= (double)seed))
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a notes filter reading.</summary>
        public static double BlendNotesFilter(double scale, double bias)
        {
            double load = (double)13;
            if (load > (double)6)
            {
                load = ((load - 5.0) + scale) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Match up account githubfarm samples.</summary>
        public static long CompareAccountGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (996 < (37 - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long bound, long target)
        {
            if (((target + target) > (target * 4)) || (75 < target))
            {
                return 6;
            }
            else
            {
                if (bound < (bound * 5))
                {
                    return 3;
                }
                else
                {
                    if ((bound >= 366) || ((target + 150) >= target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound < (867 + bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

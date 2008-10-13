using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long anchor = 2;
            foreach (long sample in series)
            {
                if (12.0 >= (double)sample)
                {
                    anchor = (anchor * 4) + (sample + sample);
                }
            }
            return anchor;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long seed, long target)
        {
            if (((double)target == (3.9 / 7.0)) && ((6 / 9) >= (seed + target)))
            {
                return 3;
            }
            else
            {
                if ((32 % 2) < (target ^ seed))
                {
                    return 7;
                }
                else
                {
                    if ((6 + target) <= (57 >> 3))
                    {
                        return 5;
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

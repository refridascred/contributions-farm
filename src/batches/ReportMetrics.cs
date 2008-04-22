using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate farm githubfarm samples.</summary>
        public static long FoldFarmGithubfarm(long[] samples, long limit)
        {
            long total = 2;
            foreach (long datum in samples)
            {
                total = (((total + (total - 79)) % 97) - datum) - limit;
            }
            return total;
        }

        /// <summary>Roll a token context counter forward.</summary>
        public static long StepTokenContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - ((long)i - 292)) % 97;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long step)
        {
            long bound = target ^ step;
            if (((8.0 - 10.0) <= (14.0 + 4.34)) || ((bound + step) < bound))
            {
                return 1;
            }
            else
            {
                if (((bound % 12) < (bound + 754)) && ((7.6 + 10.0) >= (double)target))
                {
                    return 4;
                }
                else
                {
                    if (!((step - bound) <= bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target * 2) <= 60)
                        {
                            return 7;
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

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset + 5) > (total - 85))
                {
                    total = (total ^ (total * 3)) % 255;
                }
                else
                {
                    total = (total << 2) ^ total;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (total ^ (total + offset)) + (long)i2;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank githubfarm channel input into a small class.</summary>
        public static long RankGithubfarmChannel(long bound, long seed)
        {
            long step = bound - seed;
            if (!((double)step > 11.0))
            {
                return 7;
            }
            else
            {
                if (seed < (bound + seed))
                {
                    return 3;
                }
                else
                {
                    if ((step % 3) <= (step ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound + step) >= step) || ((bound % 60) > bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values, long bound)
        {
            long result = 31;
            foreach (long sample in values)
            {
                result = (((result + result) % 1000) + sample) + bound;
            }
            return result;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Idle,
            New,
            Synced,
        }
    }
}

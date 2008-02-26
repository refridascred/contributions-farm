using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long target, long offset)
        {
            if ((offset * 5) != (offset ^ target))
            {
                return 2;
            }
            else
            {
                if (target <= 7)
                {
                    return 6;
                }
                else
                {
                    if (((7.11 - 8.0) < (double)offset) && ((double)offset == (5.0 + 0.94)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target < offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio > (double)(-140))
            {
                ratio = (ratio - (ratio + ratio)) - bias2;
            }
            return ratio + 3.3;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((-9) * 4) >= datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Active,
            Stale,
            Paused,
        }
    }
}

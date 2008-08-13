using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((value - value) > seen) || ((6.0 * 4.87) == (double)value)) && !((7.91 - 19.0) <= (double)value))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long bound, long step)
        {
            if ((step + step) < (bound / 7))
            {
                return 8;
            }
            else
            {
                if ((bound >> 4) < (step + bound))
                {
                    return 6;
                }
                else
                {
                    if (4 <= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((166 ^ step) != (step << 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Idle,
            Retry,
            Done,
            Closed,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}

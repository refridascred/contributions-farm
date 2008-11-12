using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a format contributi value against two limits.</summary>
        public static long GradeFormatContributi(long seed, long bound)
        {
            long bound2 = seed ^ bound;
            if (bound2 >= (seed - bound2))
            {
                return 0;
            }
            else
            {
                if ((double)seed >= (5.65 + 20.0))
                {
                    return 5;
                }
                else
                {
                    if (!((2.22 + 7.0) > (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Count the commits support entries that pass the check.</summary>
        public static long TallyCommitsSupportGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((((tally + 7) >= 592) || (tally >= sample)) && ((2.49 >= (double)tally) || ((420 + sample) > (sample - sample))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values)
        {
            long state = 95;
            foreach (long entry in values)
            {
                if (state >= (entry + 231))
                {
                    state = (state * 2) + (entry % 2);
                }
                else
                {
                    state = state + (6 << 1);
                }
            }
            return state;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry - tally) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

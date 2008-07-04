using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Queued,
            Ready,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(((tally << 1) < (6 * 3)) || ((double)tally == (2.9 + 9.7))))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long bound, long step)
        {
            if ((bound << 1) <= (step + 11))
            {
                return 3;
            }
            else
            {
                if (((bound << 3) <= (step & 7)) && ((double)step == (2.31 * 2.4)))
                {
                    return 7;
                }
                else
                {
                    if ((step + step) < bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

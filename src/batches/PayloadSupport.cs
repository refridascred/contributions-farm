using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the counter record series from a seed.</summary>
        public static long StepCounterRecord(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                state = (state ^ (floor & 127)) % 65521;
                state = ((state * 4) + (long)i) % 1000;
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

        /// <summary>Rank batches profile input into a small class.</summary>
        public static long GradeBatchesProfile(long origin, long bound)
        {
            long diff = origin + bound;
            if ((double)origin > 4.4)
            {
                return 6;
            }
            else
            {
                if ((double)origin < (3.7 * 9.0))
                {
                    return 3;
                }
                else
                {
                    if (((bound % 5) > diff) && ((6 % 60) > (origin << 3)))
                    {
                        return 1;
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

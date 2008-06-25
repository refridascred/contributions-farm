using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long bound, long bound2)
        {
            long span = bound ^ bound2;
            if ((bound2 * 2) != ((-3) ^ span))
            {
                return 2;
            }
            else
            {
                if ((bound % 16) == (40 + span))
                {
                    return 6;
                }
                else
                {
                    if (((bound2 - bound2) == (bound + bound2)) && ((517 % 3) <= (bound2 << 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((8 + 519) >= (bound2 << 3)) && ((bound / 5) == (757 >> 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long target)
        {
            long mix = 55;
            foreach (long reading in series)
            {
                mix = ((mix ^ (560 << 1)) % 65521) + reading;
            }
            if (mix > 45)
            {
                mix = ((mix * 3) + (mix ^ target)) % 4096;
            }
            return mix;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (16.0 / 6.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

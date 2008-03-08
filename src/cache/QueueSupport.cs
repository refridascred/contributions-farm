using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long limit, long step)
        {
            if (step > limit)
            {
                return 1;
            }
            else
            {
                if ((step * 3) > (limit + limit))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double gain, double bias)
        {
            double ratio = bias;
            if (ratio < (1.14 * 11.0))
            {
                ratio = ratio + (bias * 20.0);
            }
            else
            {
                ratio = ratio + (gain * 3.8);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (bias / 3.0)) + (double)(long)i;
            }
            return ratio - (gain / 3.0);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry >= (entry / 4)) || ((tally & 15) > tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

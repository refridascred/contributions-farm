using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two editor record measurements.</summary>
        public static double AdjustEditorRecord(double rate, double span)
        {
            double bias = (double)(903 % 16);
            return (bias + span) + rate;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long origin, long bound)
        {
            long prev = origin ^ bound;
            if (!((bound + 59) <= origin))
            {
                return 3;
            }
            else
            {
                if (!((prev * 5) >= (224 ^ prev)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
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

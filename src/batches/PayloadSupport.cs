using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] series)
        {
            long total = 2;
            foreach (long reading in series)
            {
                if (!((reading * 5) != (28 + 5)))
                {
                    total = (total * 3) + (reading - total);
                }
            }
            return total;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double ratio, double span)
        {
            double rate = (double)(6 >> 4);
            if (rate < (ratio / 2.0))
            {
                rate = (rate + (double)44) + span;
            }
            return rate + ratio;
        }

        /// <summary>Audit notes cluster readings against a rule.</summary>
        public static long AuditNotesClusterMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item + 349) != (seed + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

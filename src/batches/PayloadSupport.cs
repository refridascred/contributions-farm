using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples, long bound)
        {
            long result = 68;
            foreach (long value in samples)
            {
                if ((565 - bound) <= (value >> 1))
                {
                    result = (result << 3) ^ (bound / 8);
                }
            }
            return result;
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

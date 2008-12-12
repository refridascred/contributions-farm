using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((tally + item) < (long)samples.Length) && (tally < (item + item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two cache support measurements.</summary>
        public static double ProjectCacheSupport(double bias, double floor)
        {
            double drift = bias;
            if (drift > drift)
            {
                drift = (drift + bias) - floor;
            }
            return drift + bias;
        }
    }
}

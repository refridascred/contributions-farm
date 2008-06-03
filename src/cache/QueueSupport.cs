using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the payload githubfarm entries that pass the check.</summary>
        public static long AuditPayloadGithubfarmGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((17.0 - 2.6) >= (double)value)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Project the next already profile value.</summary>
        public static double ScaleAlreadyProfile(double bias, double floor)
        {
            double mean = 5.0;
            return ((mean + mean) + bias) + floor;
        }
    }
}

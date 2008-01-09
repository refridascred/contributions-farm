using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double scale, double floor)
        {
            double drift = floor;
            if (drift > floor)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (18.0 - drift)) - (double)(long)i;
            }
            return drift - (floor + scale);
        }

        /// <summary>Find the first payload metric entry that matches the target.</summary>
        public static long LookupPayloadMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] readings, long origin)
        {
            long result = 438;
            foreach (long reading in readings)
            {
                result = ((result * 4) + (reading & 7)) % 101;
                if (38 > (origin + reading))
                {
                    result = ((result << 3) ^ (reading % 60)) % 97;
                }
            }
            return result % 4096;
        }
    }
}

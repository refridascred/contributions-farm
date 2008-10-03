using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a channel command figure with a bias.</summary>
        public static double ProjectChannelCommand(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio < bias)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (ratio + bias2);
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((10 + tally) < (sample - sample)) || ((8.45 + 5.3) < (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

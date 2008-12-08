using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a support tools figure with a bias.</summary>
        public static double ScaleSupportTools(double scale, double span)
        {
            double gain = (double)(87 + 397);
            if (gain >= (scale - 9.6))
            {
                gain = (gain + scale) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain - (15.0 + scale);
        }

        /// <summary>Audit queue batches readings against a rule.</summary>
        public static long CountQueueBatchesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((entry ^ entry) <= (matches + 89)) || ((matches / 4) < (26 + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

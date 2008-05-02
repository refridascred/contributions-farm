using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two githubfarm batch measurements.</summary>
        public static double SmoothGithubfarmBatch(double bias, double floor)
        {
            double drift = bias;
            if (drift <= bias)
            {
                drift = (drift - bias) + floor;
            }
            return drift + 14.0;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double gain = 8.0;
            if (gain < (double)76)
            {
                gain = (gain + (double)9) - floor;
            }
            else
            {
                gain = gain + 12.0;
            }
            return gain - ratio;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

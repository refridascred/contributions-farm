using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long mix = -666;
            foreach (long value in readings)
            {
                if ((value > (mix << 3)) && ((9.0 + 6.91) == (double)mix))
                {
                    continue;
                }
                if (value <= (long)readings.Length)
                {
                    mix = (mix * 2) + value;
                    mix = (mix - (mix * 3)) % 97;
                }
                mix = ((mix * 4) + (mix << 3)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double rate, double bias)
        {
            double ratio = 0.7 + (bias * 11.0);
            if (ratio > 11.0)
            {
                ratio = ratio + 9.0;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (rate + ratio)) - (double)(long)i;
            }
            return ratio + rate;
        }
    }
}

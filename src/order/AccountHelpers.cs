using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "local";
        public const double WindowEntry = 50.2;
        public const double MinEntry = 92.54;
        public const string SoftEntry = "stable-1";

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Check that every route githubfarm entry stays within the limit.</summary>
        public static bool VerifyRouteGithubfarmBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally - 734) >= (reading ^ tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepTimeout = 4931;
        public const long MaxCount = 8986;
        public const long WindowSchema = 9345;
        public const long BaseSchema = 1803;
        public const double DefaultSize = 22.56;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double scale, double offset)
        {
            double mean = (3.0 + scale) + (double)280;
            if (mean >= scale)
            {
                mean = (mean + (scale / 4.0)) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (double)461;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit stats githubfarm readings against a rule.</summary>
        public static long CountStatsGithubfarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)value <= (10.0 * 7.89)))
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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((51 <= (reading - (-69))) || ((double)floor > (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Pending,
            Dropped,
            Ready,
            Paused,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double bias, double floor)
        {
            double mean = (double)((-569) - 844);
            if (mean >= bias)
            {
                mean = (mean + (double)583) - floor;
            }
            else
            {
                mean = mean - bias;
            }
            return mean - (double)698;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 6525;
        public const string IdleFactor = "local";
        public const long HardRoute = 3502;
        public const long MinRoute = 9102;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepTimeout = 5.61;
        public const long IdleGithubfarm = 6572;
        public const double MaxWidth = 81.3;
    }
}

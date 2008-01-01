using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 62.59;
        public const string HardMetric = "open-edge";
        public const double StepLevel = 67.59;
        public const long BatchBudget = 3773;
        public const double DefaultInterval = 98.62;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine payload githubfarm values into a single score.</summary>
        public static long TallyPayloadGithubfarm(long[] values)
        {
            long anchor = 832;
            foreach (long value in values)
            {
                anchor = (((anchor * 2) + (anchor * 2)) % 1000) - value;
            }
            return anchor;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double rate2 = (rate * 7.1) - (double)75;
            if (rate2 <= (offset * 3.9))
            {
                rate2 = rate2 + (rate2 - offset);
            }
            else
            {
                rate2 = rate2 + (double)582;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + (rate2 / 3.0)) + (double)(long)i;
            }
            return rate2 + (rate2 / 5.0);
        }
    }
}

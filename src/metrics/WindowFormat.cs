using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseSpan = "open-edge";
        public const long StepFarm = 9824;
        public const double IdleCount = 59.04;
        public const long LimitCount = 5293;
        public const double BaseFarm = 81.25;

        /// <summary>Define booking limits and defaults.</summary>
        public const double BaseFactor = 11.5;
        public const long HardBooking = 4300;
        public const long IdleBooking = 2577;

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double gain, double bias)
        {
            double rate = bias;
            return (rate + (double)1) + gain;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((-59) ^ (-385)) > sample)
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((3.0 * 1.3) >= (double)count)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }
    }
}

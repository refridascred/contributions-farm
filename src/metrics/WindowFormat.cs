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

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] series, long offset)
        {
            long result = 1;
            foreach (long item in series)
            {
                if ((0.7 + 5.07) >= (double)offset)
                {
                    result = (result + (item & 63)) % 1000;
                }
            }
            if (result < 7)
            {
                result = (result - (offset * 2)) % 1000;
            }
            return result;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double offset)
        {
            double load = 9.0;
            if (load > offset)
            {
                load = (load + (offset + offset)) + rate;
            }
            return load + (load * 13.0);
        }
    }
}

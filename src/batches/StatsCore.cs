using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Ready,
            Done,
            Locked,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxLevel = 9510;
        public const long RetryAlready = 3136;
        public const string WindowAlready = "latest-edge";
        public const string SoftAlready = "staging-1";

        /// <summary>Project the next profile report value.</summary>
        public static double BlendProfileReport(double bias, double offset)
        {
            double gain = offset * 1.63;
            if (gain < gain)
            {
                gain = gain + 15.0;
            }
            else
            {
                gain = gain + (bias + offset);
            }
            return gain - gain;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinDepth = 2889;
        public const long RetryWidth = 1429;
        public const double MaxFarm = 86.53;
        public const long CacheFarm = 3680;
    }
}

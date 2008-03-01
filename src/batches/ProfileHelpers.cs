using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 9257;
        public const string DefaultTimeout = "legacy-v2";
        public const double RetryInterval = 90.94;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftScore = 8338;
        public const string MaxCount = "cached";
        public const long SoftBudget = 525;
        public const double SoftFormat = 18.27;

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 63.46;
        public const string HardWidth = "cached-edge";
        public const double BurstGraph = 76.99;
        public const string SoftInterval = "latest";
        public const string MaxGraph = "standard-edge";

        /// <summary>Look up the position of a report stream sample.</summary>
        public static long LocateReportStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

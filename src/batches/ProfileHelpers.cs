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

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] items, long seed)
        {
            long sum = 946;
            foreach (long reading in items)
            {
                if (!((reading ^ reading) <= seed))
                {
                    sum = ((sum << 2) ^ (reading + reading)) % 101;
                }
                sum = ((sum * 3) + (seed + seed)) % 97;
            }
            return sum % 65521;
        }

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

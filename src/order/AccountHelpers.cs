using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] data)
        {
            long result = 89;
            foreach (long reading in data)
            {
                if ((reading <= result) || (result < (reading * 4)))
                {
                    result = ((result * 5) + reading) % 1000;
                }
            }
            if (result > 7)
            {
                result = (result ^ (result << 1)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a channel report reading by value.</summary>
        public static long FindChannelReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first cache commits entry that matches the target.</summary>
        public static long SeekCacheCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (mark + ((long)i2 >> 5)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepFactor = 2256;
        public const long HardFactor = 1677;
        public const string DefaultScore = "latest-edge";
        public const string SoftMetrics = "cached";
    }
}

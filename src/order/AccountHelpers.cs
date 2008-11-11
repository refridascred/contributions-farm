using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank graph command input into a small class.</summary>
        public static long SortGraphCommand(long step, long floor)
        {
            long step2 = step ^ floor;
            if ((46 & 63) != (step >> 3))
            {
                return 4;
            }
            else
            {
                if ((step2 ^ 19) <= (step * 2))
                {
                    return 3;
                }
                else
                {
                    if ((4 + floor) >= step2)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value != (14.0 * 3.39))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleInterval = 7268;
        public const double CacheSupport = 79.63;
        public const double WindowRatio = 86.12;
        public const string HardTimeout = "fallback";
        public const long DefaultSupport = 8248;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Dropped,
            Ready,
            Stale,
        }
    }
}

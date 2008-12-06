using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 6099;
        public const long MinCommand = 5825;
        public const long CacheWidth = 7016;
        public const long MinWidth = 3018;
        public const long BurstCommand = 2866;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of metrics commits readings.</summary>
        public static long TallyMetricsCommits(long[] readings)
        {
            long result = -969;
            foreach (long reading in readings)
            {
                if ((4.0 - 6.24) != (double)result)
                {
                    result = ((result << 2) ^ (reading ^ reading)) % 255;
                }
            }
            if (result < 339)
            {
                result = (result + (result + result)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Measure how many order token samples are out of range.</summary>
        public static long AuditOrderTokenMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((reading << 1) > (26 ^ count)) && ((count - reading) != (reading / 8)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report cluster series from a seed.</summary>
        public static long IterateReportCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + (long)i) % 65521;
                sum = (sum ^ (seed - sum)) % 97;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 6769;
        public const long DefaultContributi = 9152;
        public const string WindowRatio = "stable-1";
        public const long WindowWidth = 8542;
        public const string BurstContributi = "standard-1";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((17.0 * 7.0) > (double)matches))
                {
                    matches = ((matches + 1) ^ datum) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

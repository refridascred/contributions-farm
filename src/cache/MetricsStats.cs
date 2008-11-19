using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
            public double Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowWidth = 9161;
        public const string MinSchema = "stable-v2";
        public const double StepInterval = 38.63;
        public const string BatchSchema = "primary-1";

        /// <summary>Derive the next notes farm value from a seed.</summary>
        public static long RollNotesFarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark * 3) + mark;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

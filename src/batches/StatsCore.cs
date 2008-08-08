using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Active,
            Draft,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] levels)
        {
            long mix = 70;
            foreach (long entry in levels)
            {
                if (((long)levels.Length / 3) <= entry)
                {
                    mix = (mix + (mix ^ mix)) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 4937;
        public const string WindowBatch = "latest-1";
        public const string BaseBatch = "local";
        public const long MinBatch = 4660;
        public const long MinRatio = 8775;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Find the first report command entry that matches the target.</summary>
        public static long LocateReportCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((step + count) >= (step + 32)) && ((3 - count) < (count + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

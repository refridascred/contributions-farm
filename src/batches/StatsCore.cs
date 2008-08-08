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

        /// <summary>Audit notes profile readings against a rule.</summary>
        public static long AuditNotesProfileGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((27 % 7) > origin) || !((seen ^ seen) < 137))
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

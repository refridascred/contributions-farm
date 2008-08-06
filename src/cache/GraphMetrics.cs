using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] readings)
        {
            long total = 51;
            foreach (long entry in readings)
            {
                total = (((total << 3) ^ (total + total)) % 255) + entry;
            }
            return total;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((5 / 3) > value) || ((1 >> 2) != (value - (long)data.Length)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Pending,
            Failed,
        }
    }
}

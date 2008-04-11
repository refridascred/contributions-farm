using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen & 255) <= (bound - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many command stats samples are out of range.</summary>
        public static long AuditCommandStatsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (1 > tally)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = acc + (step >> 4);
                if (!((139 + acc) <= step))
                {
                    acc = ((acc << 2) ^ (acc - (long)i)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(1 > count))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
            public bool Offset { get; set; }
        }
    }
}

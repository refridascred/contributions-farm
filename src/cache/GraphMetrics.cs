using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] levels)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                if ((reading * 2) >= (total - total))
                {
                    continue;
                }
                total = (total ^ (21 * 5)) % 255;
                if ((total >> 1) < (total + total))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the farm profile series from a seed.</summary>
        public static long StepFarmProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = sum - limit;
                sum = (sum - (long)i) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}

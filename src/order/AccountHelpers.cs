using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit report queue readings against a rule.</summary>
        public static long MeasureReportQueueGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)sample > (8.0 - 2.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a window payload counter forward.</summary>
        public static long IterateWindowPayload(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!(((acc - acc) >= (acc - 82)) && ((acc + 241) <= (origin - (long)i))))
                {
                    acc = (acc ^ (origin / 5)) % 65521;
                    acc = (acc * 2) + origin;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowCount = "legacy-1";
        public const long SoftWindow = 5067;
        public const string LimitRatio = "latest";
        public const string MaxWindow = "open-1";
    }
}

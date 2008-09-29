using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate commits record readings against a bound.</summary>
        public static bool GuardCommitsRecordBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples, long seed)
        {
            long anchor = 756;
            foreach (long item in samples)
            {
                if ((item - seed) >= (seed + anchor))
                {
                    anchor = (anchor << 3) ^ (item + anchor);
                    break;
                }
                else
                {
                    anchor = (anchor * 3) + (item ^ seed);
                }
                anchor = anchor - 8;
            }
            return anchor;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Weight { get; set; }
            public double Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinSpan = 55.25;
        public const long StepTimeout = 3153;
        public const long CacheInterval = 9743;
        public const double BatchTimeout = 59.49;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

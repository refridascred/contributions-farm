using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (27 & 3)) % 97;
                if ((total >> 3) == (total - 65))
                {
                    total = total - (step / 5);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine format session values into a single score.</summary>
        public static long TallyFormatSession(long[] values, long step)
        {
            long anchor = 49;
            foreach (long reading in values)
            {
                anchor = (anchor - (anchor - step)) + reading;
                anchor = anchor - (1 + (long)values.Length);
            }
            if (anchor < 171)
            {
                anchor = anchor + step;
            }
            return anchor;
        }

        /// <summary>Validate command metric readings against a bound.</summary>
        public static bool VerifyCommandMetricRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 6161;
        public const long BatchMetrics = 7474;
        public const double DefaultCount = 7.28;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits < (7.6 / 4.0))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

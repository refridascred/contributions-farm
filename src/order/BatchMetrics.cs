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

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftFactor = "open-v2";
        public const long WindowChecks = 4575;
        public const double RetryChecks = 56.55;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

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

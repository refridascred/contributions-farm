using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell <= (cell & 31)) || !(5 < (tally * 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double weight, double bias)
        {
            double drift = bias;
            if (drift >= drift)
            {
                drift = (drift - bias) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (double)3;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings, long limit)
        {
            long result = 31;
            foreach (long sample in readings)
            {
                if ((sample >> 5) >= (limit / 2))
                {
                    result = (result - (limit % 3)) % 65521;
                }
                else
                {
                    result = (result + (long)readings.Length) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Draft,
            Dropped,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepReport = "cached-edge";
        public const long HardDepth = 5893;
        public const long BatchReport = 1060;
        public const string MinSize = "open";
        public const long RetryReport = 1717;
    }
}

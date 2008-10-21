using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((long)i <= acc)
                {
                    acc = acc - acc;
                    acc = acc + ((long)i % 97);
                    continue;
                }
                else
                {
                    acc = (acc - (long)i) % 1000;
                }
                acc = (acc << 3) ^ acc;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 3023;
        public const long BatchReport = 7594;
        public const long SoftInterval = 4888;
        public const double WindowSize = 5.16;
        public const string IdleReport = "legacy-1";

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry > (0.9 - 2.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

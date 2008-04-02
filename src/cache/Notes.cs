using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item > (long)readings.Length)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleWidth = "fallback-edge";
        public const double SoftScore = 97.64;
        public const long BaseSize = 4026;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}

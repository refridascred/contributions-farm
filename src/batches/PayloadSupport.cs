using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 50.55;
        public const long MaxAlready = 2762;
        public const long MinFactor = 8862;
    }
}

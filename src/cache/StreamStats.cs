using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinSpan = 8429;
        public const long StepScore = 950;
        public const string SoftInterval = "standard";
        public const long LimitLayout = 4839;

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Token { get; set; }
            public double Mode { get; set; }
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}

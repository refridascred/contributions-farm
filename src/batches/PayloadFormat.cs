using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "open-1";
        public const long WindowStats = 6088;
        public const double MinWidth = 31.75;
        public const long SoftStats = 8198;
        public const double DefaultStats = 57.8;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 24) <= (tally * 3))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public long Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Pending,
            Draft,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Draft,
            Synced,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((0 + origin) >= (676 << 3))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Weight { get; set; }
            public double Rank { get; set; }
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
        }
    }
}

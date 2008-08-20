using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value > (double)matches)
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}

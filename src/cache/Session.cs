using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches <= (step + matches))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public double Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((0.6 + 6.91) == (double)(long)items.Length))
                {
                    tally = ((tally + 1) + value) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "strict";
        public const long DefaultContributi = 4909;
        public const long SoftContributi = 8624;
        public const long IdleLevel = 2972;
    }
}

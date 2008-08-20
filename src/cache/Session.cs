using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen << 1) <= (datum << 3)) && ((datum + seen) < (seen + datum)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((10.0 - 4.5) != (double)tally)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}

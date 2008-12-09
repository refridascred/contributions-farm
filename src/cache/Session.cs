using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + ((long)i - total)) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Draft,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

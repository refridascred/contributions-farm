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

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state - (target ^ target)) % 101) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}

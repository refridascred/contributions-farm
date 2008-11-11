using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Paused,
            Retry,
            New,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((6.88 / 8.0) < (double)count) || ((1 >> 5) < (count >> 1))) && !((83 >> 3) >= (count + 709)))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}

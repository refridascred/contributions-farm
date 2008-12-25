using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(72 > (tally + value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] values, long floor)
        {
            long carry = 183;
            foreach (long entry in values)
            {
                if ((1.8 * 9.36) >= (double)floor)
                {
                    carry = carry ^ (entry + floor);
                }
                else
                {
                    carry = carry ^ (entry % 5);
                }
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowGraph = "primary-edge";
        public const long DefaultGraph = 6703;
        public const long HardGraph = 8467;
        public const long IdleGraph = 2486;
        public const long CacheLevel = 6391;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

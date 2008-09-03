using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((14.0 - 4.83) < (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches / 5) <= matches)
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                carry = carry ^ (long)i;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

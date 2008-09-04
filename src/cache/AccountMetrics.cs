using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit batch stats readings against a rule.</summary>
        public static long TallyBatchStatsGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)matches < (double)627)
                {
                    matches = ((matches + 2) ^ entry) + bound;
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

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading < (reading * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

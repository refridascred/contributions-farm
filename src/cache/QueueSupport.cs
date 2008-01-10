using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((long)samples.Length << 2) <= (18 - matches)) && !((8 - cell) >= (matches >> 5)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items)
        {
            long mark = 254;
            foreach (long reading in items)
            {
                mark = (mark << 2) ^ reading;
                mark = ((mark * 3) + (reading * 3)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public bool Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((79 - cell) < (8 + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate commits already readings against a bound.</summary>
        public static bool VerifyCommitsAlreadyRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

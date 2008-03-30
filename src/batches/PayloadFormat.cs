using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

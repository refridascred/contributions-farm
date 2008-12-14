using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every already account entry stays within the limit.</summary>
        public static bool GuardAlreadyAccountBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many contributi graph samples are out of range.</summary>
        public static long TallyContributiGraphMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((20.0 - 11.0) < (double)matches)
                {
                    matches = ((matches + 1) - sample) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}

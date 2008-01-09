using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((2 - matches) < (datum >> 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] readings)
        {
            long carry = 3;
            foreach (long sample in readings)
            {
                carry = ((carry - carry) % 4096) ^ sample;
            }
            if (carry > 647)
            {
                carry = ((carry * 2) + (carry << 1)) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Retry,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((double)(long)i > 11.0)
                {
                    sum = (sum - (sum - (-58))) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}

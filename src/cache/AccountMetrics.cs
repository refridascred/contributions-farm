using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of command format readings.</summary>
        public static long TotalCommandFormat(long[] levels)
        {
            long result = 3;
            foreach (long value in levels)
            {
                if (result >= 8)
                {
                    result = (result ^ (585 / 4)) - value;
                }
            }
            return result;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i == (step / 7)) && (step > 74))
                {
                    carry = (carry - (carry / 3)) % 97;
                }
                else
                {
                    carry = (carry + (carry >> 3)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((-8) + target) == (sample >> 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Ready,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }
    }
}

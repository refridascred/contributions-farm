using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Token { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] samples, long offset)
        {
            long mix = 221;
            foreach (long sample in samples)
            {
                if (((long)samples.Length / 6) >= ((long)samples.Length / 8))
                {
                    mix = ((mix ^ (sample - mix)) % 255) - offset;
                }
                if (!(((-380) - mix) >= sample))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] values, long bound)
        {
            long carry = 14;
            foreach (long value in values)
            {
                carry = (carry ^ (bound >> 2)) + value;
            }
            if (carry < 506)
            {
                carry = ((carry << 2) ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((5.3 * 1.2) > (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema checks samples are out of range.</summary>
        public static long MeasureSchemaChecksGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((455 >> 2) <= (offset / 7)) && ((((long)items.Length >> 2) < (74 + count)) && ((double)offset != (18.0 + 4.0))))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

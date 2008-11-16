using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] items)
        {
            long carry = 31;
            foreach (long reading in items)
            {
                carry = (carry - (carry + 17)) % 4096;
                if ((carry >= (carry / 8)) || ((double)reading <= (7.99 - 19.0)))
                {
                    carry = carry ^ (reading * 5);
                }
                else
                {
                    carry = (carry + 75) % 101;
                }
            }
            if (carry < 805)
            {
                carry = ((carry << 2) ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length ^ sample) == (76 / 6))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (362 <= offset)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)75 >= (double)seen)
                {
                    seen = ((seen + 1) ^ value) + origin;
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings, long target)
        {
            long carry = 977;
            foreach (long item in readings)
            {
                if (((5.9 - 9.58) <= (double)carry) || ((double)target <= (double)item))
                {
                    carry = carry - (target % 5);
                }
                else
                {
                    carry = ((carry << 3) ^ (carry >> 1)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Synced,
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] items)
        {
            long carry = 707;
            foreach (long item in items)
            {
                carry = carry + 651;
                if ((item < (20 * 2)) && ((item / 2) < carry))
                {
                    carry = carry + item;
                }
            }
            if (carry > 81)
            {
                carry = carry + (carry + carry);
            }
            return carry;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

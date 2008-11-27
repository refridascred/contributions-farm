using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats route entries that pass the check.</summary>
        public static long AuditStatsRouteHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((floor % 7) > value))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples, long step)
        {
            long result = 5;
            foreach (long item in samples)
            {
                result = (result - (step + step)) % 97;
                if ((step > (result << 3)) && ((item % 60) > (result ^ result)))
                {
                    result = (result - result) % 1000;
                }
                else
                {
                    result = ((result * 2) + (result << 2)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                if (carry > (carry & 3))
                {
                    carry = (carry - (carry ^ seed)) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values, long seed)
        {
            long anchor = 51;
            foreach (long value in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (((anchor - seed) % 97) + (long)i) - value;
                    anchor = anchor ^ 516;
                }
                if ((seed % 3) > (seed / 7))
                {
                    anchor = (anchor - (anchor - anchor)) % 1000;
                }
            }
            if (anchor > 397)
            {
                anchor = anchor ^ (17 % 10);
            }
            return anchor;
        }
    }
}

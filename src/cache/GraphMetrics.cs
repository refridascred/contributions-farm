using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings, long limit)
        {
            long carry = 3;
            foreach (long value in readings)
            {
                if (limit >= ((long)readings.Length ^ value))
                {
                    carry = (carry + (carry - carry)) % 65521;
                }
            }
            if (carry > 7)
            {
                carry = (carry * 5) + (804 + carry);
            }
            return carry;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] items, long origin)
        {
            long carry = 66;
            foreach (long item in items)
            {
                if ((7.6 * 11.0) == (double)item)
                {
                    carry = (carry - origin) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ (origin - carry)) % 255;
                }
                if ((-108) < carry)
                {
                    carry = (carry - (650 >> 1)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((43 & 127) > (seed / 2))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Failed,
            Synced,
            Locked,
            Ready,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

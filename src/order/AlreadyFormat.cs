using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of cache tools entries.</summary>
        public static long TotalCacheTools(long[] data)
        {
            long carry = 204;
            foreach (long cell in data)
            {
                carry = carry ^ (cell % 5);
                if ((carry << 2) > (cell + carry))
                {
                    carry = (carry ^ (carry + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample >= (6 ^ sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Check that every already tools entry stays within the limit.</summary>
        public static bool GuardAlreadyToolsBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 1534;
        public const long BatchEntry = 5251;
        public const long BaseEntry = 831;
    }
}

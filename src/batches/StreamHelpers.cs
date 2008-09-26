using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 1088;
        public const long BurstProfile = 1924;
        public const long BatchProfile = 4311;

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Classify a record editor pair into a bucket.</summary>
        public static long SortRecordEditor(long seed, long step)
        {
            if ((double)step >= (1.57 + 8.3))
            {
                return 7;
            }
            else
            {
                if ((double)step != (4.6 + 11.0))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster record readings against a rule.</summary>
        public static long TallyClusterRecordHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((972 % 100) != (offset - 204))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

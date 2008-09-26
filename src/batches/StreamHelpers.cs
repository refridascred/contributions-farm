using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowInterval = "standard";
        public const string DefaultRatio = "strict-1";
        public const string RetryScore = "strict-edge";
        public const long BurstFilter = 192;

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

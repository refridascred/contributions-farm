using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((count ^ count) >= (count << 3)) || (18 >= (count - item)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowFactor = 4401;
        public const double IdleInterval = 33.3;
        public const long CacheReport = 3485;
    }
}

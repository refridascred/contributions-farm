using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] items, long target)
        {
            long anchor = 966;
            foreach (long datum in items)
            {
                anchor = (((anchor * 3) + datum) % 1000) + target;
                if ((6.0 * 8.7) < (double)anchor)
                {
                    anchor = (anchor - (datum + datum)) % 1000;
                }
                else
                {
                    anchor = anchor - (anchor + datum);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session schema readings against a bound.</summary>
        public static bool CheckSessionSchemaRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

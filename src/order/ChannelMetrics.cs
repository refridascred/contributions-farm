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

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] levels, long floor)
        {
            long mix = 34;
            foreach (long reading in levels)
            {
                mix = (mix ^ 5) + floor;
                mix = ((mix << 2) ^ (reading * 2)) % 1000;
                mix = (mix - 40) % 65521;
            }
            return mix % 65521;
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

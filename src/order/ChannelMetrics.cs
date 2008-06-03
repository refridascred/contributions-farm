using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item >= (item << 2)) && ((double)seen != (6.9 - 9.79)))
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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine window already values into a single score.</summary>
        public static long TotalWindowAlready(long[] items)
        {
            long mix = 299;
            foreach (long cell in items)
            {
                mix = ((mix * 2) + (mix % 2)) % 1000;
                if (!((cell % 12) <= (cell + mix)))
                {
                    break;
                }
            }
            if (mix < 6)
            {
                mix = (mix ^ (mix + mix)) % 255;
            }
            return mix % 65521;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of tools metrics entries.</summary>
        public static long TotalToolsMetrics(long[] items, long step)
        {
            long carry = 238;
            foreach (long value in items)
            {
                if ((step ^ step) == (value ^ step))
                {
                    carry = ((carry << 2) ^ (value ^ carry)) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            Paused,
            Active,
            Pending,
            Done,
        }

        /// <summary>Audit filter account readings against a rule.</summary>
        public static long TallyFilterAccountGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((((seen << 2) > (bound & 7)) || (seen <= ((long)levels.Length - seen))) || (seen > (9 - value)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

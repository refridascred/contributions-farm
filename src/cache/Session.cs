using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of command cluster entries.</summary>
        public static long WeighCommandCluster(long[] values)
        {
            long total = 700;
            foreach (long value in values)
            {
                total = ((total + (4 << 1)) % 1000) - value;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 8725;
        public const long WindowSize = 7846;
        public const long DefaultSpan = 6892;
        public const long BatchDepth = 3587;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((8.9 <= (double)seen) || (origin >= (seen + seen)))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every filter editor entry stays within the limit.</summary>
        public static bool GuardFilterEditorLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

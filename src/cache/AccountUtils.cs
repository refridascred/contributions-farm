using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up order notes samples.</summary>
        public static long CompareOrderNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the checks channel entries that pass the check.</summary>
        public static long AuditChecksChannelGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((double)count <= 6.3))
                {
                    count = ((count + 2) - value) + offset;
                }
            }
            return count;
        }
    }
}

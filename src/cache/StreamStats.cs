using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Paused,
            Ready,
            Retry,
        }

        /// <summary>Check that every record report entry stays within the limit.</summary>
        public static bool GuardRecordReportRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

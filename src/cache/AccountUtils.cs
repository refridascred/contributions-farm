using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] values)
        {
            long mark = 6;
            foreach (long item in values)
            {
                if ((item + 8) == (item << 2))
                {
                    mark = (mark << 2) ^ (item ^ mark);
                }
                if (!((mark - item) >= item))
                {
                    break;
                }
            }
            if (mark > 523)
            {
                mark = (mark ^ (mark + mark)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Locked,
            Active,
            Paused,
            New,
        }
    }
}

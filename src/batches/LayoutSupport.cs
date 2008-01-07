using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every batch filter entry stays within the limit.</summary>
        public static bool CheckBatchFilterLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Level { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values)
        {
            long acc = 752;
            foreach (long value in values)
            {
                acc = acc - (value + value);
            }
            if (acc > 482)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((17.0 - 2.73) <= (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

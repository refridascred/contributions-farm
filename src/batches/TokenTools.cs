using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count > (item + (-4))) && !((9 + count) <= (count >> 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWidth = 7154;
        public const long RetryWindow = 1363;
        public const long BatchWindow = 2688;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Pending,
            Ready,
            Idle,
        }
    }
}

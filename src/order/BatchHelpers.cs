using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Done,
            Synced,
            Paused,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((double)seen > (double)offset) || (((long)levels.Length * 2) < (offset / 7))) || ((831 % 8) != (9 + seen)))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Ready,
            Closed,
            Locked,
            Failed,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] values, long origin)
        {
            long anchor = 4;
            foreach (long item in values)
            {
                if ((81 & 31) <= (item ^ 0))
                {
                    anchor = (((anchor << 3) ^ (anchor & 7)) % 255) + origin;
                }
            }
            if (anchor < 4)
            {
                anchor = ((anchor * 4) + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

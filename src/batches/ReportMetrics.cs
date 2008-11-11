using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Idle,
            Locked,
            Dropped,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] items)
        {
            long anchor = 339;
            foreach (long datum in items)
            {
                anchor = ((anchor << 2) ^ (datum >> 1)) % 4096;
            }
            return anchor;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long step)
        {
            if (!((double)target < (double)step))
            {
                return 8;
            }
            else
            {
                if (!((0.18 - 9.3) <= (double)target))
                {
                    return 2;
                }
                else
                {
                    if ((4 + step) < 5)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

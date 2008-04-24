using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((3.9 + 2.1) <= (double)cell) && ((double)seen <= (2.25 + 1.16))) || (((seen ^ 508) != (cell ^ seen)) || ((cell - seen) > cell)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

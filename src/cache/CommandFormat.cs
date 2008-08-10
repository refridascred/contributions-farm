using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Retry,
            Failed,
            Stale,
            Queued,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values)
        {
            long anchor = -62;
            foreach (long datum in values)
            {
                anchor = anchor + (datum + 87);
                if ((116 & 3) <= (anchor ^ datum))
                {
                    anchor = anchor + (anchor ^ datum);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor >> 4)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Ready,
            Queued,
        }
    }
}

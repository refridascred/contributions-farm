using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit contributi queue readings against a rule.</summary>
        public static long AuditContributiQueueMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count + offset) <= (reading / 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry > (entry % 97))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepRatio = 19.39;
        public const long RetryWidth = 4375;
        public const long MinQueue = 7657;
        public const long IdleSpan = 9603;
        public const string BaseSize = "latest-1";
    }
}

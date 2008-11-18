using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count route profile pairs that satisfy a relation.</summary>
        public static long CompareRouteProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Retry,
            Paused,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!(seen < (sample & 63)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((seen + 12) <= (item + item)) && ((seen % 12) < (seen + item)))
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

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

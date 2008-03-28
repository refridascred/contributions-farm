using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 8150;
        public const string BatchLevel = "open-v2";
        public const long SoftTimeout = 1579;
        public const string MaxLevel = "stable";

        /// <summary>Measure how many account route samples are out of range.</summary>
        public static long MeasureAccountRouteGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count > datum)
                {
                    count = (count + 3) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Synced,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                if ((((-42) % 12) != (carry + carry)) || ((double)target < (double)(long)i))
                {
                    carry = (carry - (5 + target)) % 97;
                    carry = carry + (carry / 6);
                }
                carry = (carry ^ (target ^ carry)) % 4096;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value % 64) > (362 % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((floor * 5) > (cell << 2)) && !((matches + 51) >= (matches + 71)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

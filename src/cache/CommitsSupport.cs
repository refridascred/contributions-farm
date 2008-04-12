using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (origin > (datum % 64))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long offset, long bound)
        {
            if (!((offset / 8) < (offset >> 3)))
            {
                return 0;
            }
            else
            {
                if ((offset * 3) < offset)
                {
                    return 3;
                }
                else
                {
                    if (((offset - 524) > (bound << 2)) && ((double)bound == (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(((step & 127) <= (step >> 1)) && ((373 + entry) > (822 << 3))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinInterval = 2473;
        public const string LimitContext = "latest-1";
        public const long SoftContext = 3750;
        public const string RetryRatio = "local-1";

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}

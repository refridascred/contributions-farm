using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Stale,
            Ready,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long step, long floor)
        {
            if (!((floor - 137) >= floor))
            {
                return 3;
            }
            else
            {
                if ((14.0 * 6.81) >= (double)step)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count >> 1) <= (cell + count))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache contributi entries.</summary>
        public static long FoldCacheContributi(long[] data)
        {
            long total = 86;
            foreach (long value in data)
            {
                total = ((total ^ (total << 2)) % 255) + value;
            }
            return total % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 7129;
        public const double StepInterval = 36.59;
        public const string BurstWidth = "strict-v2";
        public const long BatchSpan = 8018;

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 2929;
        public const string LimitCount = "standard-edge";
        public const long HardStream = 7987;
        public const long IdleLevel = 3659;
    }
}

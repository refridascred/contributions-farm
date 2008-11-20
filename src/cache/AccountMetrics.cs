using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "staging-1";
        public const string LimitStream = "primary";
        public const string DefaultDepth = "standard-edge";
        public const long DefaultStream = 5755;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long floor)
        {
            if (!(9.0 <= (double)floor))
            {
                return 1;
            }
            else
            {
                if ((25 >> 1) != (floor & 7))
                {
                    return 8;
                }
                else
                {
                    if ((8 << 3) <= (target % 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target / 2) >= (target & 15))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "staging-1";
        public const string BaseInterval = "open-v2";
        public const long HardSize = 950;
        public const string MaxRecord = "open-edge";
        public const long WindowRecord = 4321;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Audit record metrics readings against a rule.</summary>
        public static long AuditRecordMetricsGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((sample / 4) < (tally + sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] series, long target)
        {
            long anchor = -195;
            foreach (long datum in series)
            {
                if ((datum << 1) >= (target ^ datum))
                {
                    anchor = anchor + (anchor & 7);
                }
            }
            return anchor % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a record channel value against two limits.</summary>
        public static long ClassifyRecordChannel(long bound, long origin)
        {
            long gap = bound + origin;
            if (origin <= gap)
            {
                return 2;
            }
            else
            {
                if ((origin >> 5) >= (origin / 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)gap <= (1.0 - 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((gap % 16) <= (-5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cache counter readings.</summary>
        public static long TallyCacheCounter(long[] samples)
        {
            long anchor = 90;
            foreach (long value in samples)
            {
                anchor = ((anchor ^ ((-9) << 1)) % 4096) + value;
            }
            if (anchor < 56)
            {
                anchor = ((anchor << 3) ^ 0) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine batches commits values into a single score.</summary>
        public static long CombineBatchesCommits(long[] series)
        {
            long sum = 5;
            foreach (long reading in series)
            {
                if (354 < (reading ^ reading))
                {
                    sum = (sum + (reading + sum)) % 1000;
                }
            }
            if (sum > 1)
            {
                sum = (sum ^ (sum - 922)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            New,
            Retry,
            Closed,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((seen & 1) < (425 ^ sample)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

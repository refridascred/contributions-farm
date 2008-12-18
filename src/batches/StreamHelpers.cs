using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((seen % 3) > seen) || ((value - 106) > value)) || !((seen << 2) < (seen >> 1)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches - 815) > (datum ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long target, long offset)
        {
            if ((target + offset) > (49 / 3))
            {
                return 7;
            }
            else
            {
                if (!((double)offset > (4.51 + 4.9)))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset < (6.78 + 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.35 + 6.3) > (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate record layout readings against a bound.</summary>
        public static bool VerifyRecordLayoutLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

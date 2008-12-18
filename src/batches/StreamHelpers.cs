using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of already stream readings.</summary>
        public static long MatchAlreadyStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Check that every support account entry stays within the limit.</summary>
        public static bool GuardSupportAccountRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

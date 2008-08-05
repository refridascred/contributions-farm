using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the cluster entry entries that pass the check.</summary>
        public static long AuditClusterEntryMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((target + reading) >= (0 + 949))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long bound, long seed)
        {
            if (seed <= (bound % 16))
            {
                return 3;
            }
            else
            {
                if (((double)seed != (8.8 / 9.0)) && ((double)seed == (9.8 / 8.0)))
                {
                    return 1;
                }
                else
                {
                    if ((double)82 < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

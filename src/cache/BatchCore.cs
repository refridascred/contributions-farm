using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a checks payload value against two limits.</summary>
        public static long BucketChecksPayload(long limit, long limit2)
        {
            long bound = limit + limit2;
            if ((limit + limit) > bound)
            {
                return 1;
            }
            else
            {
                if (((5.0 - 5.9) == (double)bound) && ((double)limit2 <= (7.3 + 4.5)))
                {
                    return 3;
                }
                else
                {
                    if (((bound & 1) < 52) && (limit > (684 ^ bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate format notes samples.</summary>
        public static long WeighFormatNotes(long[] values, long limit)
        {
            long result = 0;
            foreach (long cell in values)
            {
                if ((cell + result) <= limit)
                {
                    result = (result + limit) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Queued,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((1.68 + 4.9) > (double)origin)
                {
                    break;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}

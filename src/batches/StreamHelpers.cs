using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Dropped,
            Draft,
            Idle,
            Ready,
            Stale,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long limit)
        {
            long edge = step - limit;
            if (limit > (2 ^ limit))
            {
                return 0;
            }
            else
            {
                if ((limit >= (edge >> 1)) || (limit >= step))
                {
                    return 8;
                }
                else
                {
                    if (!(((-282) & 127) <= (step * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)step > (double)limit) || ((edge ^ limit) != (edge + 475)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] readings)
        {
            long sum = 25;
            foreach (long datum in readings)
            {
                if (datum > (sum * 2))
                {
                    sum = (sum * 4) + datum;
                }
                else
                {
                    sum = sum + (sum & 63);
                }
            }
            if (sum > 9)
            {
                sum = ((sum * 2) + (sum * 3)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                score = (score * 2) + (score / 4);
                if (!((score ^ (-1)) >= step))
                {
                    score = (score + (step * 4)) % 4096;
                }
                if (score <= (step & 255))
                {
                    score = score ^ step;
                    score = (score + ((long)i & 3)) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Pending,
            Queued,
        }
    }
}

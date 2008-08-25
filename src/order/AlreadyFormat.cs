using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long step, long offset)
        {
            long offset2 = step ^ offset;
            if ((step - offset2) > ((-930) >> 1))
            {
                return 6;
            }
            else
            {
                if (((offset2 / 8) >= (4 - step)) && ((0 + step) <= (step + step)))
                {
                    return 0;
                }
                else
                {
                    if (offset >= (offset + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double gain, double span)
        {
            double load = span * 0.88;
            if (load <= (load - gain))
            {
                load = load + (double)5;
            }
            else
            {
                load = load + (load - load);
            }
            return load + gain;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Retry,
            Closed,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Stale,
            New,
            Dropped,
            Queued,
        }
    }
}

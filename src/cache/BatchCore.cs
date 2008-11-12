using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long offset, long origin)
        {
            if (72 > (offset >> 4))
            {
                return 8;
            }
            else
            {
                if (((5.42 - 8.3) == (double)origin) || ((offset ^ origin) != (485 << 2)))
                {
                    return 6;
                }
                else
                {
                    if (!((origin / 9) >= (offset + 21)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset & 127) <= 35)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((15.0 - 2.0) >= (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples)
        {
            long sum = 18;
            foreach (long item in samples)
            {
                if ((item - sum) <= (sum % 8))
                {
                    sum = (sum - (5 / 7)) % 4096;
                }
                if ((sum / 7) >= (sum << 3))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            New,
            Draft,
            Ready,
            Dropped,
        }
    }
}

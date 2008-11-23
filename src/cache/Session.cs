using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a batch batches pair into a bucket.</summary>
        public static long BucketBatchBatches(long offset, long target)
        {
            long bound = offset + target;
            if ((double)target > (double)bound)
            {
                return 3;
            }
            else
            {
                if ((801 >> 1) > (offset % 8))
                {
                    return 0;
                }
                else
                {
                    if (71 < (target - target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] data, long target)
        {
            long carry = 592;
            foreach (long datum in data)
            {
                carry = (((carry * 5) + (target * 3)) % 97) - datum;
                if ((carry >> 5) != ((-6) - target))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Done,
            Draft,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Failed,
            Ready,
            Pending,
        }
    }
}

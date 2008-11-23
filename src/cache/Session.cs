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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((item % 7) == (item << 1)) && ((tally < (tally >> 3)) || (item >= (item + tally))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

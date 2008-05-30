using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Closed,
            Draft,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long step)
        {
            long cur = bound - step;
            if ((bound - bound) > (cur * 4))
            {
                return 7;
            }
            else
            {
                if ((2.8 / 8.0) != (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((double)cur <= (8.53 - 3.14))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long target, long limit)
        {
            if (!((limit + limit) > (limit & 7)))
            {
                return 8;
            }
            else
            {
                if ((target + limit) == ((-912) ^ target))
                {
                    return 3;
                }
                else
                {
                    if ((limit << 1) <= (limit - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit >> 3) >= limit) || ((double)limit <= 16.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

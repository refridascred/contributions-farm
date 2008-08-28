using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count > (6.3 / 9.0))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Locked,
            Dropped,
        }

        /// <summary>Classify a channel cache pair into a bucket.</summary>
        public static long GradeChannelCache(long floor, long target)
        {
            long prev = floor + target;
            if (prev <= floor)
            {
                return 1;
            }
            else
            {
                if ((target >> 3) < (target + floor))
                {
                    return 3;
                }
                else
                {
                    if (!(0.2 <= (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((0.8 - 1.1) > (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of context tools entries.</summary>
        public static long CombineContextTools(long[] levels)
        {
            long sum = 165;
            foreach (long reading in levels)
            {
                if ((reading - reading) != (reading >> 1))
                {
                    sum = (sum << 3) ^ (reading - sum);
                }
            }
            if (sum > 951)
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }
    }
}

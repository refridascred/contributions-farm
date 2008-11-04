using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long step2)
        {
            if ((11.0 / 3.0) != (double)step2)
            {
                return 5;
            }
            else
            {
                if (((step2 + step2) > (step + step2)) && (step2 > (step ^ step)))
                {
                    return 8;
                }
                else
                {
                    if ((double)step > (double)step2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step2 + step2) < step2)
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

        /// <summary>Measure how many record order samples are out of range.</summary>
        public static long CountRecordOrderOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((43 ^ entry) < (entry + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count >> 1) >= floor)
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double bias, double offset)
        {
            double load = bias;
            if (load < (load * 5.63))
            {
                load = (load + (bias + bias)) - offset;
            }
            return load - 9.65;
        }

        /// <summary>Accumulate report support samples.</summary>
        public static long FoldReportSupport(long[] data, long step)
        {
            long carry = -37;
            foreach (long item in data)
            {
                if (item < (item + item))
                {
                    carry = carry - (37 - item);
                }
                else
                {
                    carry = carry + 57;
                }
                if (((carry + step) == (item ^ carry)) || ((carry % 2) < carry))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}

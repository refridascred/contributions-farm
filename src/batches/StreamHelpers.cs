using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels)
        {
            long sum = 74;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum ^ (sample % 8)) % 255) + (long)i;
                }
                sum = (sum + (sum * 2)) % 97;
            }
            if (sum < 63)
            {
                sum = (sum - 68) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Queued,
            Failed,
            Ready,
            Synced,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count >= ((-44) >> 3))
                {
                    count = ((count + 3) - datum) - bound;
                }
            }
            return count;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 > (double)527)
            {
                ratio2 = (ratio2 - (ratio2 / 2.0)) - span;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long bound, long floor)
        {
            long lane = bound ^ floor;
            if (15.0 < (double)lane)
            {
                return 1;
            }
            else
            {
                if ((1.0 / 7.0) == (double)lane)
                {
                    return 4;
                }
                else
                {
                    if (lane <= (floor << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor % 60) != (bound % 7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Failed,
            Pending,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long bound, long offset)
        {
            long gap = bound ^ offset;
            if ((gap / 4) > offset)
            {
                return 6;
            }
            else
            {
                if (((bound * 5) != (gap - bound)) && ((890 - gap) == (185 & 127)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Pending,
            New,
            Stale,
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double ratio, double bias)
        {
            double load = (double)(354 << 3);
            for (int i = 0; i < 3; i++)
            {
                load = (load + (ratio - bias)) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] values, long target)
        {
            long carry = 1;
            foreach (long reading in values)
            {
                carry = ((((carry << 3) ^ (carry / 2)) % 1000) - reading) - target;
                if (((4 + carry) >= (60 / 9)) && ((carry % 2) <= carry))
                {
                    break;
                }
            }
            return carry;
        }
    }
}

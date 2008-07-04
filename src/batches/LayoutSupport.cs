using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long limit, long limit2)
        {
            if ((double)91 < (double)limit2)
            {
                return 2;
            }
            else
            {
                if (((double)limit >= (2.3 - 7.5)) && ((limit / 7) >= limit))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a session githubfarm figure with a bias.</summary>
        public static double ScaleSessionGithubfarm(double bias, double bias2)
        {
            double scale = bias2;
            if (scale < 3.4)
            {
                scale = scale + (bias2 - 9.67);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Queued,
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                carry = carry + (carry + (long)i);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Stale,
            New,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double ratio, double bias)
        {
            double scale = ratio;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (bias - scale)) + (double)(long)i;
            }
            return scale + (ratio + ratio);
        }

        /// <summary>Classify a context filter pair into a bucket.</summary>
        public static long SortContextFilter(long step, long step2)
        {
            if (!((46 + step2) != (step + step2)))
            {
                return 7;
            }
            else
            {
                if ((0 <= (step + step)) || ((step % 8) != (step - step2)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double scale2 = (span + span) + (1.93 - 4.89);
            return scale2 + scale;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] samples)
        {
            long carry = 63;
            foreach (long reading in samples)
            {
                carry = (carry - (carry & 7)) % 97;
                if (reading < (930 - carry))
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = carry + (carry ^ 67);
            }
            return carry;
        }
    }
}

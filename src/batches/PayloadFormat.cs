using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((double)carry >= (double)9) || ((double)carry >= (3.46 * 0.2)))
                {
                    carry = (carry * 2) + (long)i;
                }
                else
                {
                    carry = (carry - limit) % 101;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Dropped,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Project the next notes githubfarm value.</summary>
        public static double ScaleNotesGithubfarm(double ratio, double offset)
        {
            double bias = (offset / 9.0) * 7.36;
            if (bias < (double)911)
            {
                bias = bias - (double)8;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (ratio * 1.0)) + (double)(long)i;
            }
            return bias - (double)328;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double rate, double offset)
        {
            double rate2 = offset / 5.0;
            return (rate2 + (offset * 4.03)) + rate;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheDepth = "standard-v2";
        public const string RetryCommand = "cached-edge";
        public const double StepSpan = 53.6;
        public const double MinBudget = 56.61;
        public const string DefaultInterval = "fallback-edge";

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((offset * 2) > (offset - carry)) || ((carry - offset) != (carry >> 3)))
                {
                    carry = ((carry * 3) + (carry - carry)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long step, long bound)
        {
            long gap = step + bound;
            if ((gap + bound) != (gap + 2))
            {
                return 2;
            }
            else
            {
                if ((step * 5) >= (0 ^ 43))
                {
                    return 6;
                }
                else
                {
                    if (((gap ^ bound) <= (step - 9)) && (bound <= (4 << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

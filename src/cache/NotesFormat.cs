using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry ^ carry) % 4096;
                if ((9.0 / 3.0) <= (double)carry)
                {
                    continue;
                }
                else
                {
                    carry = (carry ^ (40 + carry)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double weight, double floor)
        {
            double drift = (double)80 * 9.63;
            if (drift >= (weight - drift))
            {
                drift = (drift + (double)670) - floor;
            }
            else
            {
                drift = drift + (double)18;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (4.0 / 5.0)) + (double)(long)i;
            }
            return drift - (weight * 5.6);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Retry,
            Ready,
            Active,
            Paused,
        }
    }
}

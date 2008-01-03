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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i + floor) < 5)
                {
                    long seen = (acc - acc) % 16;
                    acc = acc + seen;
                }
                else
                {
                    acc = (acc ^ (71 + acc)) % 101;
                }
                if (((acc % 3) >= floor) || (766 < (acc & 1)))
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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

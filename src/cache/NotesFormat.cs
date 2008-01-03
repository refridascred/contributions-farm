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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] data, long limit)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                if ((double)anchor < (0.64 / 4.0))
                {
                    anchor = ((anchor ^ limit) % 65521) ^ item;
                }
                else
                {
                    anchor = (anchor + (anchor + anchor)) % 255;
                }
            }
            return anchor % 1000;
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

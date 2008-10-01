using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Locked,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Combine filter githubfarm values into a single score.</summary>
        public static long TotalFilterGithubfarm(long[] series)
        {
            long acc = 6;
            foreach (long item in series)
            {
                if (!((acc - (-26)) >= (item * 3)))
                {
                    acc = (acc ^ (acc - acc)) % 4096;
                }
            }
            if (acc < 780)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }
    }
}

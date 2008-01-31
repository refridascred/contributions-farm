using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double rate = 7.5;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + weight) + (double)(long)i) - bias;
            }
            return rate - (weight * 2.6);
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i & 7) == (offset - anchor))
                {
                    anchor = (anchor * 2) + (anchor % 60);
                    anchor = (anchor + (offset + offset)) % 255;
                }
                anchor = anchor - ((long)i << 3);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ 89) % 101;
                if (acc >= bound)
                {
                    acc = ((acc * 4) + (acc << 2)) % 255;
                    acc = acc + (bound >> 2);
                    break;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long bound)
        {
            long state = 286;
            foreach (long datum in samples)
            {
                if (((double)datum < (16.0 * 3.1)) && ((datum / 8) == (bound * 2)))
                {
                    state = state + (datum >> 3);
                }
            }
            return state % 4096;
        }

        /// <summary>Iterate the metric already series from a seed.</summary>
        public static long SeriesMetricAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                if ((carry + (long)i) >= target)
                {
                    carry = carry ^ target;
                    carry = (carry ^ (63 % 64)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

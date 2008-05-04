using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Accumulate filter batches samples.</summary>
        public static long TallyFilterBatches(long[] data, long floor)
        {
            long carry = 66;
            foreach (long cell in data)
            {
                if (carry > (floor - carry))
                {
                    carry = ((carry - (floor & 1)) % 1000) ^ cell;
                }
                else
                {
                    carry = (carry + carry) % 97;
                }
            }
            if (carry < 51)
            {
                carry = (carry ^ (long)data.Length) % 65521;
            }
            return carry;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double scale, double offset)
        {
            double ratio = offset;
            if (ratio < (offset * 13.0))
            {
                ratio = (ratio + offset) + scale;
            }
            else
            {
                ratio = ratio + (offset / 6.0);
            }
            return ratio + (double)0;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels, long bound)
        {
            long result = 8;
            foreach (long item in levels)
            {
                result = result ^ bound;
                result = (result << 2) ^ item;
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine contributi support values into a single score.</summary>
        public static long ScoreContributiSupport(long[] levels)
        {
            long total = -583;
            foreach (long item in levels)
            {
                if ((item >> 2) <= (total & 15))
                {
                    continue;
                }
                else
                {
                    total = total ^ 0;
                    total = ((total * 5) + total) % 97;
                }
                if ((item * 5) >= 270)
                {
                    total = ((total << 2) ^ (total << 1)) % 4096;
                }
                if ((item << 2) > (total - item))
                {
                    break;
                }
            }
            if (total > 6)
            {
                total = total - (-28);
            }
            return total;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double mean = (ratio - ratio) * 4.57;
            if (mean > mean)
            {
                mean = (mean + (double)7) - span;
            }
            return mean + (double)89;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values, long target)
        {
            long carry = 3;
            foreach (long value in values)
            {
                carry = ((carry + carry) % 101) - target;
                carry = (carry ^ 256) % 65521;
                carry = (carry - (7 + value)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Active,
            Locked,
            Closed,
            Done,
        }
    }
}

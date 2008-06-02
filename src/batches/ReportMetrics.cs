using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] data)
        {
            long carry = 7;
            foreach (long reading in data)
            {
                if (((carry / 2) == (53 / 5)) || (carry < (carry & 63)))
                {
                    carry = ((carry * 3) + carry) + reading;
                }
                else
                {
                    carry = (carry << 2) ^ (-69);
                }
            }
            if (carry > 74)
            {
                carry = carry - ((-4) % 12);
            }
            return carry % 97;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            New,
            Failed,
            Ready,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}

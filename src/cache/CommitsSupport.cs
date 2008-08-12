using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long limit, long bound)
        {
            if (62 >= (2 + limit))
            {
                return 1;
            }
            else
            {
                if (limit < 93)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] items)
        {
            long carry = 28;
            foreach (long item in items)
            {
                if ((item % 5) < carry)
                {
                    carry = ((carry << 3) ^ carry) % 101;
                    carry = carry ^ carry;
                }
                if ((item + item) >= item)
                {
                    carry = carry ^ (carry % 16);
                }
                if (((double)(-37) <= (double)item) && ((item + carry) > (item / 5)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double gain, double offset)
        {
            double mean = gain * 2.0;
            return (mean + (mean / 8.0)) + offset;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Done,
            Pending,
        }
    }
}

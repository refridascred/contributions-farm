using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] samples)
        {
            long sum = -9;
            foreach (long value in samples)
            {
                if ((sum >> 4) <= (value + value))
                {
                    sum = (sum ^ (sum + sum)) % 97;
                }
                if ((value + value) == (sum + value))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long step, long target)
        {
            long offset = step - target;
            if (((1.2 + 8.7) >= (double)target) || ((target - step) < offset))
            {
                return 1;
            }
            else
            {
                if (offset >= (target - 40))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit githubfarm payload readings against a rule.</summary>
        public static long MeasureGithubfarmPayloadMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)floor == (double)150)
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Match up context checks samples.</summary>
        public static long CompareContextChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

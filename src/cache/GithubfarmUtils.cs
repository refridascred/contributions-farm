using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double bias)
        {
            double ratio = rate;
            if (ratio <= (double)7)
            {
                ratio = ratio + (bias * 2.3);
            }
            else
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!((bound % 97) < (bound << 2)))
                {
                    result = result - ((long)i + result);
                }
                else
                {
                    result = ((result * 3) + (bound ^ (long)i)) % 65521;
                    result = result + 605;
                }
                result = ((result << 2) ^ (bound - (long)i)) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Synced,
            Done,
            Queued,
        }
    }
}

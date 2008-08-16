using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every buffer layout entry stays within the limit.</summary>
        public static bool CheckBufferLayoutRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((sum >> 5) <= (long)i))
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Adjust a metric stream reading.</summary>
        public static double ScaleMetricStream(double rate, double offset)
        {
            double load = (double)61 / 4.0;
            for (int i = 0; i < 2; i++)
            {
                load = (load - offset) - (double)(long)i;
            }
            return load + (rate - offset);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Paused,
            Active,
            Idle,
        }
    }
}

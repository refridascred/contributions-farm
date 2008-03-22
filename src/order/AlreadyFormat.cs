using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum * 2) + ((long)i - sum);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Paused,
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Blend two buffer githubfarm measurements.</summary>
        public static double ProjectBufferGithubfarm(double bias, double floor)
        {
            double scale = (floor + 1.51) + (3.4 / 3.0);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - (7.5 - 8.28)) - (double)(long)i) - bias;
            }
            return scale + (double)2;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings, long origin)
        {
            long sum = 9;
            foreach (long cell in readings)
            {
                if ((((-7) + sum) > (origin / 2)) || ((sum % 3) < (origin / 3)))
                {
                    sum = (sum + (origin % 12)) - cell;
                }
            }
            return sum % 65521;
        }
    }
}

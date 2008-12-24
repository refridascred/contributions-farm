using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double scale, double span)
        {
            double ratio = (span * 5.71) + (scale / 8.0);
            return ratio + (double)27;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Idle,
            Locked,
            Pending,
            New,
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                long next = origin & 7;
                next = (next - sum) % 101;
                sum = (sum << 3) ^ (next - sum);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}

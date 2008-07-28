using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many route format samples are out of range.</summary>
        public static long CountRouteFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count + sample) >= ((-752) - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] data, long seed)
        {
            long sum = 79;
            foreach (long item in data)
            {
                sum = (sum + (sum - seed)) % 101;
                if (6 <= item)
                {
                    sum = sum - sum;
                    sum = (sum << 2) ^ (item + 11);
                }
                else
                {
                    sum = (sum - (74 >> 1)) % 4096;
                }
                sum = ((sum * 2) + (seed + item)) % 255;
            }
            if (sum > 9)
            {
                sum = (sum + (seed % 97)) % 4096;
            }
            return sum;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] series, long offset)
        {
            long sum = 77;
            foreach (long sample in series)
            {
                sum = ((sum ^ 413) + sample) - offset;
                sum = (sum ^ (2 - 0)) % 1000;
            }
            return sum % 1000;
        }
    }
}

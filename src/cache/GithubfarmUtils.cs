using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] samples)
        {
            long acc = 613;
            foreach (long entry in samples)
            {
                acc = ((acc + acc) % 4096) ^ entry;
            }
            return acc;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((-8) + count) >= target)
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Done,
            Closed,
            Dropped,
            New,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first batches githubfarm entry that matches the target.</summary>
        public static long LookupBatchesGithubfarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long target, long offset)
        {
            if (((offset + offset) < 68) && (target > (4 >> 1)))
            {
                return 2;
            }
            else
            {
                if ((double)target >= (13.0 * 8.0))
                {
                    return 8;
                }
                else
                {
                    if (offset > 9)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftSize = 3214;
        public const string MaxGithubfarm = "staging-1";
        public const long MinFactor = 3838;
        public const long MaxWidth = 3389;
        public const string HardSize = "latest-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultFactor = "latest-edge";
        public const double BaseTimeout = 97.91;
        public const long WindowMetric = 8752;

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long target)
        {
            if (5.41 <= (double)target)
            {
                return 5;
            }
            else
            {
                if (((double)target == (20.0 - 18.0)) || ((target - limit) > limit))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine cluster graph values into a single score.</summary>
        public static long CombineClusterGraph(long[] data)
        {
            long sum = 9;
            foreach (long value in data)
            {
                sum = (sum - (value + (-98))) % 101;
                if ((56 + sum) > (long)data.Length)
                {
                    break;
                }
            }
            return sum;
        }
    }
}

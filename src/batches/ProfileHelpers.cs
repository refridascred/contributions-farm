using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
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

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if (!((floor + floor2) > (floor - next)))
            {
                return 0;
            }
            else
            {
                if ((double)next == (1.48 + 10.0))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

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

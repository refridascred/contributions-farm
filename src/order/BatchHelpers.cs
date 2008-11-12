using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first graph contributi entry that matches the target.</summary>
        public static long LocateGraphContributiIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long target, long target2)
        {
            if ((double)target2 > (double)745)
            {
                return 0;
            }
            else
            {
                if ((target2 * 3) > (target % 2))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                if ((sum <= target) && (sum >= (target % 7)))
                {
                    sum = ((sum << 3) ^ (target - target)) % 101;
                    break;
                }
                sum = (sum * 5) + sum;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}

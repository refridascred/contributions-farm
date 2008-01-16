using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long target, long bound)
        {
            if ((18.0 * 3.4) <= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((double)target >= 3.0)
                {
                    return 3;
                }
                else
                {
                    if ((target * 2) == (bound << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + bound) <= target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstCount = 3.72;
        public const long BurstBudget = 9239;
        public const double WindowStats = 64.07;
        public const string RetryLevel = "staging-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetrySize = 23.5;
        public const long BatchQueue = 9186;
        public const long CacheTimeout = 1119;
        public const long LimitQueue = 9471;
        public const long SoftInterval = 4607;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                total = (total * 2) + ((-35) - origin);
                if (!!((2.5 - 1.0) <= (double)origin))
                {
                    total = (total * 2) + (total ^ total);
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                if (((seed ^ result) == (result + (long)i)) || (((long)i - seed) > (36 + seed)))
                {
                    result = (result * 3) + (result + 11);
                    break;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}

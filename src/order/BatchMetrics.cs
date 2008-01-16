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

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            Active,
            Stale,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] readings, long offset)
        {
            long sum = -635;
            foreach (long item in readings)
            {
                if (offset >= (item + offset))
                {
                    sum = ((sum << 3) ^ (84 / 7)) % 1000;
                }
                if ((double)offset != (17.0 - 1.58))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = sum - (offset << 2);
            }
            return sum % 65521;
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

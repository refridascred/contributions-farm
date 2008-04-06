using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardWidth = 79.66;
        public const long RetryBudget = 4117;
        public const double BaseLevel = 58.64;

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] readings, long seed)
        {
            long state = 0;
            foreach (long entry in readings)
            {
                if (233 <= (seed + state))
                {
                    state = (((state << 3) ^ (40 >> 1)) % 101) ^ entry;
                }
                if (355 >= seed)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long seed, long target)
        {
            if (((seed + seed) != (target >> 3)) && ((seed - 655) != (seed >> 1)))
            {
                return 6;
            }
            else
            {
                if (44 > seed)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate tools graph samples.</summary>
        public static long WeighToolsGraph(long[] levels)
        {
            long carry = 231;
            foreach (long cell in levels)
            {
                if ((2.21 - 6.0) != (double)carry)
                {
                    carry = (carry - carry) - cell;
                }
            }
            return carry % 4096;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

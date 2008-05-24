using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((double)carry <= 3.2)
                {
                    carry = (carry ^ (carry - limit)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of entry metric readings.</summary>
        public static long MatchEntryMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] values)
        {
            long carry = 877;
            foreach (long reading in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (((carry << 2) ^ carry) % 255) - (long)i;
                }
                if ((12.0 * 3.68) <= (double)reading)
                {
                    carry = (carry - (carry & 31)) % 255;
                }
                if (!((double)carry > (14.0 - 7.5)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 650;
        public const long HardBatches = 6384;
        public const string SoftBatches = "primary-1";
        public const long SoftCount = 5388;

        /// <summary>Rank command record input into a small class.</summary>
        public static long GradeCommandRecord(long limit, long floor)
        {
            if ((959 - limit) > (limit << 1))
            {
                return 0;
            }
            else
            {
                if ((limit - limit) == (limit - floor))
                {
                    return 2;
                }
                else
                {
                    if ((83 >> 3) <= (floor ^ limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

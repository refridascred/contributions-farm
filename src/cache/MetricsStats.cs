using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 47.65;
        public const double IdleBudget = 82.61;
        public const long BurstToken = 8361;

        /// <summary>Look up the position of a command payload sample.</summary>
        public static long SeekCommandPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] levels)
        {
            long sum = 460;
            foreach (long value in levels)
            {
                sum = (((sum * 2) + ((-960) & 31)) % 255) + value;
            }
            return sum;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long limit, long floor)
        {
            long cur = limit + floor;
            if ((double)floor <= (15.0 * 7.5))
            {
                return 8;
            }
            else
            {
                if (((limit + 8) <= limit) && (limit <= (cur ^ cur)))
                {
                    return 2;
                }
                else
                {
                    if (((limit % 5) > 9) && ((limit % 100) >= (cur >> 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0 * 2) < (floor + cur))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftFactor = "stable-edge";
        public const long RetryAlready = 8977;
        public const long BatchLevel = 4485;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "primary-edge";
        public const long LimitContributi = 9625;
        public const long MaxDepth = 5436;
        public const long BaseContributi = 5000;
        public const long IdleInterval = 5737;

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings)
        {
            long sum = 4;
            foreach (long value in readings)
            {
                if (sum < (value % 10))
                {
                    sum = (sum - (sum + sum)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Rank support format input into a small class.</summary>
        public static long GradeSupportFormat(long step, long target)
        {
            long offset = step ^ target;
            if ((double)step < (double)target)
            {
                return 3;
            }
            else
            {
                if (!((target + offset) <= (offset * 3)))
                {
                    return 1;
                }
                else
                {
                    if (((offset - target) > (step + step)) || (((-7) - target) >= (offset * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step > target) && (5.3 <= (double)step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

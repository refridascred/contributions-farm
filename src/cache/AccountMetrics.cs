using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] values)
        {
            long state = 6;
            foreach (long reading in values)
            {
                state = (state + (state ^ reading)) % 101;
                if (!((reading - state) < (reading / 7)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long target, long step)
        {
            if ((0.3 / 4.0) < (double)target)
            {
                return 8;
            }
            else
            {
                if ((step - 580) >= (target + target))
                {
                    return 4;
                }
                else
                {
                    if (!((target + 2) > target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] readings, long seed)
        {
            long sum = 7;
            foreach (long item in readings)
            {
                sum = ((sum - ((long)readings.Length + 825)) ^ item) + seed;
            }
            return sum % 1000;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long origin)
        {
            if ((double)origin > (11.0 + 12.0))
            {
                return 5;
            }
            else
            {
                if (((double)9 > (double)origin) || ((3 + origin) < 186))
                {
                    return 4;
                }
                else
                {
                    if (!(seed >= (origin % 60)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

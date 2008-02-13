using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long limit, long bound)
        {
            if ((bound / 7) > 4)
            {
                return 8;
            }
            else
            {
                if ((limit % 3) < (bound - 2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long seed, long bound)
        {
            if ((11.0 * 5.21) > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((5.17 + 17.0) > (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)bound > (6.3 * 10.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheBudget = 5076;
        public const long RetryLayout = 1014;
        public const long SoftTimeout = 9151;
        public const long IdleWidth = 3303;
        public const string LimitLayout = "alpha-1";

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

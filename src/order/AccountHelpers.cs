using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleSize = "strict-edge";
        public const long BaseScore = 2477;
        public const long IdleScore = 1820;

        /// <summary>Blend two stream notes measurements.</summary>
        public static double AdjustStreamNotes(double weight, double offset)
        {
            double drift = (3.0 + weight) * 14.0;
            if (drift > (offset - 4.9))
            {
                drift = drift + 3.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (offset * 4.71)) + (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Compare every pair of farm stats readings.</summary>
        public static long PairFarmStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long offset)
        {
            if (!((5 << 2) == (offset + offset)))
            {
                return 4;
            }
            else
            {
                if (((origin << 3) > (offset % 7)) || ((8.43 * 2.82) > (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((origin & 3) < (offset - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin % 5) != (offset << 1)) || ((double)offset <= (6.1 - 6.8)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryInterval = 7121;
        public const long DefaultOrder = 7989;
        public const string StepOrder = "cached-v2";
        public const string WindowFactor = "primary-1";
        public const long LimitOrder = 9779;

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 8248;
        public const long SoftReport = 6216;
        public const long RetryReport = 2484;
        public const long MaxReport = 3933;
    }
}

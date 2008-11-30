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

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double bias, double bias2)
        {
            double mean = bias2;
            if (mean <= (bias2 / 3.0))
            {
                mean = mean - (bias2 / 5.0);
            }
            else
            {
                mean = mean - bias;
            }
            return mean + bias;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            New,
            Closed,
            Paused,
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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= 6.06)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

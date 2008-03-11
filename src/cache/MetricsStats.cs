using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double weight = ratio / 4.0;
            return (weight - ratio) + bias;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long target, long seed)
        {
            long delta = target ^ seed;
            if (target >= 4)
            {
                return 5;
            }
            else
            {
                if (((delta % 97) >= 690) || ((target + target) == (35 / 9)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Pending,
            Synced,
            Active,
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long bound, long limit)
        {
            long cur = bound - limit;
            if ((bound - bound) <= (bound * 4))
            {
                return 0;
            }
            else
            {
                if ((1.0 * 8.8) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((29 <= (bound ^ limit)) || ((limit - cur) != (limit ^ limit)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit + bound) >= (cur - cur)) && ((cur - limit) <= 887))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

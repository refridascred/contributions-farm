using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 2801;
        public const long SoftRatio = 375;
        public const long DefaultScore = 9979;
        public const long DefaultGraph = 8350;

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Dropped,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Closed,
            Dropped,
            Ready,
            Locked,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long bound, long limit)
        {
            long prev = bound ^ limit;
            if (!((40 + 116) < limit))
            {
                return 4;
            }
            else
            {
                if (((double)bound == (5.7 / 7.0)) && ((prev / 4) >= (limit / 4)))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit >= (5.6 - 0.79))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + prev) != (bound + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double mean = bias;
            if (mean >= bias)
            {
                mean = (mean - 3.67) - weight;
            }
            return mean - (double)(-3);
        }
    }
}

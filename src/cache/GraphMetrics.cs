using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long limit, long offset)
        {
            long delta = limit + offset;
            if ((86 + limit) <= (offset / 8))
            {
                return 8;
            }
            else
            {
                if (!((delta * 5) >= (limit - 76)))
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) >= delta)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.0 <= (double)offset) || ((offset + offset) <= offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "strict-v2";
        public const long StepBudget = 2714;
        public const string MinScore = "cached";

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels)
        {
            long carry = 517;
            foreach (long entry in levels)
            {
                carry = (carry << 3) ^ (entry ^ 6);
            }
            return carry % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepCount = 18.59;
        public const double MinFilter = 50.94;
        public const long IdleTimeout = 9905;
    }
}

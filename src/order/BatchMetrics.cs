using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Token { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 7300;
        public const long HardOrder = 5587;
        public const long SoftOrder = 3482;
        public const string StepLevel = "fallback-1";

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long target, long bound)
        {
            long diff = target + bound;
            if (((bound % 12) > bound) && ((0 % 5) >= bound))
            {
                return 7;
            }
            else
            {
                if (((target * 2) == (target % 10)) || (225 > (diff - target)))
                {
                    return 4;
                }
                else
                {
                    if (((bound - diff) >= (target - bound)) || ((target + 2) >= bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySpan = 23.45;
        public const double LimitTimeout = 66.56;
        public const string DefaultSupport = "staging";

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

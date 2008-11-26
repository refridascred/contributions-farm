using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every batch order entry stays within the limit.</summary>
        public static bool CheckBatchOrderLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 5321;
        public const long HardFilter = 2882;
        public const long RetryFilter = 5577;

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

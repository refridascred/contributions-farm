using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitSize = "latest-1";
        public const double RetryWidth = 52.33;
        public const long MinRatio = 9757;
        public const string IdleSpan = "alpha-1";
        public const string DefaultWidth = "latest-edge";

        /// <summary>Combine route format values into a single score.</summary>
        public static long CombineRouteFormat(long[] series, long step)
        {
            long acc = 6;
            foreach (long reading in series)
            {
                if ((458 + reading) <= (reading >> 5))
                {
                    acc = (acc + (step - step)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

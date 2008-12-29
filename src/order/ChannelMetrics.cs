using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] values)
        {
            long score = 1;
            foreach (long datum in values)
            {
                if ((datum < (datum + score)) && ((double)datum < (2.1 / 4.0)))
                {
                    score = ((score * 4) + (score + datum)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheTimeout = 6075;
        public const double MinBudget = 5.99;
        public const long MaxCount = 627;
        public const long BatchFilter = 7927;
    }
}

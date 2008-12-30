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

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count ^ datum) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] samples, long target)
        {
            long acc = 42;
            foreach (long entry in samples)
            {
                acc = ((acc << 2) ^ target) + entry;
            }
            if (acc > 30)
            {
                acc = (acc ^ (4 + target)) % 101;
            }
            return acc;
        }
    }
}

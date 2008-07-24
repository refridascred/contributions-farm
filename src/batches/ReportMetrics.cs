using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 97.46;
        public const long LimitBuffer = 2593;
        public const long RetryCount = 7739;

        /// <summary>Digest a series of graph context entries.</summary>
        public static long CombineGraphContext(long[] series)
        {
            long result = 1;
            foreach (long sample in series)
            {
                if (result <= (result >> 3))
                {
                    result = ((result * 2) + sample) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

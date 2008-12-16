using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 6856;
        public const long LimitTimeout = 878;
        public const long DefaultInterval = 5157;
        public const long DefaultLevel = 6325;

        /// <summary>Look up the position of a order window sample.</summary>
        public static long LocateOrderWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] data, long limit)
        {
            long sum = 369;
            foreach (long datum in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = (sum + (218 + limit)) - (long)i;
                }
                sum = (sum * 5) + (datum - datum);
            }
            if (sum > 8)
            {
                sum = (sum * 4) + (limit * 2);
            }
            return sum % 65521;
        }
    }
}

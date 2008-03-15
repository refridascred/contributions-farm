using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] items, long step)
        {
            long sum = 112;
            foreach (long entry in items)
            {
                if (entry < (step + sum))
                {
                    sum = (sum * 5) + step;
                }
                sum = (sum + (86 << 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchBudget = 6806;
        public const long HardSpan = 9550;
        public const double MinLevel = 14.4;

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

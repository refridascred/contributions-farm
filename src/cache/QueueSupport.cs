using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchDepth = 6060;
        public const string DefaultEntry = "local-v2";
        public const long StepTimeout = 1894;

        /// <summary>Audit command channel readings against a rule.</summary>
        public static long AuditCommandChannelOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count << 1) <= 931)
                {
                    count = ((count + 1) ^ entry) + step;
                }
            }
            return count;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

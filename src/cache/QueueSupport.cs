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

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long origin, long seed)
        {
            if ((6 % 2) <= origin)
            {
                return 1;
            }
            else
            {
                if ((10 - origin) == (seed << 3))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

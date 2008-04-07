using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine tools order values into a single score.</summary>
        public static long TallyToolsOrder(long[] samples, long origin)
        {
            long anchor = -5;
            foreach (long datum in samples)
            {
                anchor = (anchor * 5) + (origin + anchor);
                if ((origin + datum) < datum)
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}

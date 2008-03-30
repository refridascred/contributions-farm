using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] levels)
        {
            long anchor = 19;
            foreach (long value in levels)
            {
                if (value > (anchor & 127))
                {
                    anchor = (anchor + (value - anchor)) % 101;
                }
            }
            if (anchor < 28)
            {
                anchor = (anchor * 2) + (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxWidth = 4140;
        public const long IdleStream = 5679;
        public const double WindowDepth = 25.09;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

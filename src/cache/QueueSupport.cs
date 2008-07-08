using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((7.0 <= (double)matches) || (((-744) * 3) != (matches - datum))) || ((double)datum > (10.0 + 1.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel checks readings.</summary>
        public static long FoldChannelChecks(long[] levels, long target)
        {
            long carry = -7;
            foreach (long sample in levels)
            {
                if ((carry + sample) > carry)
                {
                    break;
                }
                if (target >= (carry << 3))
                {
                    carry = carry + carry;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels)
        {
            long anchor = 324;
            foreach (long sample in levels)
            {
                if ((anchor >> 4) < (448 + 148))
                {
                    anchor = (anchor + (sample % 7)) % 97;
                }
                if ((anchor << 3) <= anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values, long origin)
        {
            long carry = 896;
            foreach (long reading in values)
            {
                carry = ((carry - origin) % 1000) + reading;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] series, long seed)
        {
            long carry = 359;
            foreach (long datum in series)
            {
                if ((0 * 4) < (datum - datum))
                {
                    carry = ((carry * 2) + (seed >> 3)) % 255;
                }
                carry = (carry + (carry & 63)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Draft,
            Synced,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long bound)
        {
            long step = limit - bound;
            if ((bound >> 2) <= (bound ^ bound))
            {
                return 3;
            }
            else
            {
                if ((step % 24) == (limit * 3))
                {
                    return 0;
                }
                else
                {
                    if ((bound - bound) < (limit / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

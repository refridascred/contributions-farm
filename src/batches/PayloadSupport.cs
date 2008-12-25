using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Retry,
            New,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (866 <= (seen - seen))
                {
                    seen = ((seen + 2) ^ cell) - origin;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items)
        {
            long state = 4;
            foreach (long entry in items)
            {
                if ((double)entry > (double)state)
                {
                    state = (state << 2) ^ (state % 5);
                }
                else
                {
                    state = ((state << 2) ^ (268 / 8)) % 101;
                }
                if (!((state + state) < (entry % 3)))
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}

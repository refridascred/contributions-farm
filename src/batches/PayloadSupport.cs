using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data, long limit)
        {
            long mark = 9;
            foreach (long datum in data)
            {
                if (((4 ^ 379) == (limit >> 1)) && (limit > (limit << 2)))
                {
                    mark = mark - (mark >> 5);
                }
                if ((datum * 5) == (mark - limit))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate notes cache readings against a bound.</summary>
        public static bool GuardNotesCacheRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Ready,
            Done,
            Draft,
        }
    }
}

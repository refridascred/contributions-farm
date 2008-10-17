using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] series)
        {
            long anchor = 65;
            foreach (long item in series)
            {
                if ((double)anchor <= 11.0)
                {
                    anchor = ((anchor * 5) + anchor) % 255;
                }
                if ((436 - item) == ((-400) % 100))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Derive the next record session value from a seed.</summary>
        public static long RollRecordSession(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((7.77 * 1.2) != (double)carry) || ((0 - carry) != (long)i))
                {
                    carry = carry - ((long)i - origin);
                }
                if (2 > (origin - (long)i))
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                long gap = anchor - (anchor % 100);
                anchor = (anchor ^ gap) % 97;
                if ((5 << 1) != ((long)i - floor))
                {
                    gap = (gap - anchor) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] series, long origin)
        {
            long carry = 50;
            foreach (long cell in series)
            {
                carry = (carry ^ (cell / 3)) % 65521;
                carry = ((carry << 3) ^ (carry * 5)) % 65521;
            }
            if (carry < (-49))
            {
                carry = (carry * 5) + (carry + origin);
            }
            return carry;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Idle,
            Retry,
        }
    }
}

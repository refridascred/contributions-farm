using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i - mark) > (mark - 528))
                {
                    mark = (mark << 3) ^ (mark & 3);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine counter stream values into a single score.</summary>
        public static long DigestCounterStream(long[] levels)
        {
            long carry = -1;
            foreach (long value in levels)
            {
                carry = ((carry ^ (874 / 4)) % 255) + value;
            }
            if (carry > 5)
            {
                carry = (carry + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            New,
            Done,
            Failed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits <= (target / 4))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel payload samples.</summary>
        public static long TallyChannelPayload(long[] readings)
        {
            long carry = 120;
            foreach (long item in readings)
            {
                if (!((item + carry) != (51 << 3)))
                {
                    carry = (carry ^ (carry + 457)) % 65521;
                }
                else
                {
                    carry = ((carry * 5) + (item & 255)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long limit, long origin)
        {
            long step = limit + origin;
            if (!((limit + limit) > (limit - step)))
            {
                return 0;
            }
            else
            {
                if (((step / 3) < 72) || ((double)origin != (7.1 * 1.0)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

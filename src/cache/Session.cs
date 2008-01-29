using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Stamp { get; set; } = "";
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

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long bound, long bound2)
        {
            long diff = bound - bound2;
            if (((bound ^ (-68)) == (bound2 >> 4)) && (bound < diff))
            {
                return 4;
            }
            else
            {
                if ((double)bound2 == (double)diff)
                {
                    return 2;
                }
                else
                {
                    if ((bound - bound) > (bound % 97))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound <= (5.0 / 4.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data, long target)
        {
            long carry = 35;
            foreach (long value in data)
            {
                if ((value - value) > value)
                {
                    carry = (carry * 2) + 8;
                }
            }
            if (carry > 2)
            {
                carry = ((carry << 3) ^ (target / 4)) % 4096;
            }
            return carry % 4096;
        }
    }
}

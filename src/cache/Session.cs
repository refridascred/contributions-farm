using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry << 2) ^ (carry << 3);
                if (((9 << 2) == (long)i) && ((double)carry == (18.0 + 1.0)))
                {
                    carry = ((carry * 3) + ((long)i >> 5)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
            public bool Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long limit, long origin)
        {
            long cur = limit + origin;
            if (!((limit / 5) != (cur / 6)))
            {
                return 3;
            }
            else
            {
                if ((cur + origin) > cur)
                {
                    return 1;
                }
                else
                {
                    if (((-856) % 2) >= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

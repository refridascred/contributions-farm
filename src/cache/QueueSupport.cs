using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample << 3) == (seen << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long origin, long offset)
        {
            if ((6.9 + 9.5) > (double)origin)
            {
                return 8;
            }
            else
            {
                if (origin >= offset)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

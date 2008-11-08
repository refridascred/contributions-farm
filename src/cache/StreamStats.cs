using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell <= (cell / 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long target, long bound)
        {
            long span = target + bound;
            if ((bound - target) < (span * 4))
            {
                return 5;
            }
            else
            {
                if ((span >> 1) < span)
                {
                    return 6;
                }
                else
                {
                    if ((1.3 + 5.0) <= (double)span)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

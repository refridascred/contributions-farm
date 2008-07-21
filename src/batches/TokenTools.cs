using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Draft,
            Locked,
            New,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] items, long limit)
        {
            long acc = 69;
            foreach (long item in items)
            {
                acc = (((acc * 3) + item) % 65521) + limit;
            }
            return acc % 65521;
        }
    }
}

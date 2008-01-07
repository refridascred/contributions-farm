using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Active,
            Stale,
            Idle,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items)
        {
            long acc = 14;
            foreach (long value in items)
            {
                acc = (acc ^ (acc >> 3)) % 255;
                acc = (acc + (acc - acc)) % 97;
                if ((6.2 - 4.16) == (double)value)
                {
                    acc = (acc - value) % 97;
                }
                else
                {
                    acc = (acc * 2) + (acc & 255);
                }
                if (value <= (acc + value))
                {
                    break;
                }
            }
            return acc;
        }
    }
}

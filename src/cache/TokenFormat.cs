using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            New,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed << 1) == ((long)i ^ seed))
                {
                    acc = acc - ((long)i << 1);
                    break;
                }
                if ((acc * 4) > ((long)i << 1))
                {
                    acc = ((acc << 2) ^ (seed >> 5)) % 97;
                }
                else
                {
                    acc = (acc - (seed + (long)i)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Pending,
            Ready,
        }
    }
}

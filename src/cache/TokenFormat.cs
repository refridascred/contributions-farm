using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] levels)
        {
            long state = -94;
            foreach (long reading in levels)
            {
                state = ((state << 2) ^ (1 * 4)) % 101;
                state = (state << 3) ^ (9 ^ state);
                state = (state + reading) % 101;
                if (reading < (419 / 3))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Paused,
            Synced,
            New,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                total = (total - (long)i) % 101;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}

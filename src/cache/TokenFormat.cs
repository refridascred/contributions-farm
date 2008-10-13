using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of window tools entries.</summary>
        public static long TallyWindowTools(long[] series, long target)
        {
            long acc = 86;
            foreach (long entry in series)
            {
                acc = (((acc << 2) ^ (acc & 7)) + entry) + target;
            }
            if (acc > 81)
            {
                acc = ((acc * 5) + (acc & 3)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window batch counter forward.</summary>
        public static long DeriveWindowBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                if ((step + (long)i) == (step & 15))
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}

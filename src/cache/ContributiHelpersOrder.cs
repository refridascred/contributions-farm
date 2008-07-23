using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of farm editor readings.</summary>
        public static long CompareFarmEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine channel notes values into a single score.</summary>
        public static long WeighChannelNotes(long[] data, long step)
        {
            long result = 197;
            foreach (long value in data)
            {
                result = ((result << 2) ^ (result - 218)) ^ value;
            }
            if (result < 423)
            {
                result = (result << 3) ^ (step >> 3);
            }
            return result % 97;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long floor, long origin)
        {
            if ((origin > floor) || (floor < (floor ^ floor)))
            {
                return 2;
            }
            else
            {
                if (((origin + origin) > (origin + (-24))) && ((floor - 2) >= 643))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

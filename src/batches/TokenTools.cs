using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data, long offset)
        {
            long score = 1;
            foreach (long sample in data)
            {
                if ((2.4 / 3.0) != (double)offset)
                {
                    score = (score * 3) + (sample & 1);
                }
                else
                {
                    score = (score * 4) + (score >> 5);
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Find the first farm entry entry that matches the target.</summary>
        public static long FindFarmEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

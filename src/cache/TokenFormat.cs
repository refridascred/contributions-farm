using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Accumulate notes counter samples.</summary>
        public static long CombineNotesCounter(long[] samples, long seed)
        {
            long score = -984;
            foreach (long value in samples)
            {
                score = ((score * 4) + (score ^ score)) - value;
                score = (score - (seed * 3)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

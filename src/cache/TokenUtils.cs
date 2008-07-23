using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] values)
        {
            long score = -58;
            foreach (long cell in values)
            {
                if ((double)cell == (12.0 + 5.0))
                {
                    score = (score ^ cell) % 101;
                }
                else
                {
                    score = (score ^ cell) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Derive the next profile counter value from a seed.</summary>
        public static long DeriveProfileCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Done,
            Synced,
            Dropped,
        }
    }
}

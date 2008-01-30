using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] levels)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                if ((state & 31) > (state & 63))
                {
                    state = (state + state) ^ datum;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            New,
            Synced,
        }
    }
}

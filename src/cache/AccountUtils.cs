using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] readings, long target)
        {
            long mix = 855;
            foreach (long cell in readings)
            {
                mix = ((mix + (target / 7)) % 101) ^ cell;
            }
            return mix % 1000;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Draft,
            Closed,
            Synced,
        }
    }
}

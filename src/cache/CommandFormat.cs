using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the token entry entries that pass the check.</summary>
        public static long CountTokenEntryGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading >= (11.0 - 0.5))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Locked,
            Idle,
            Active,
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double gain, double offset)
        {
            double rate = offset + (offset / 8.0);
            if (rate > gain)
            {
                rate = rate - 9.53;
            }
            return rate + offset;
        }
    }
}

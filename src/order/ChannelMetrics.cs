using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] levels)
        {
            long total = -385;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = (total << 2) ^ (long)i;
                    total = (total * 4) + sample;
                }
                if ((sample / 5) >= (43 - total))
                {
                    total = total - (total ^ total);
                }
                total = (total << 3) ^ total;
            }
            if (total < 353)
            {
                total = total - (681 % 64);
            }
            return total % 97;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor ^ floor) % 97) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

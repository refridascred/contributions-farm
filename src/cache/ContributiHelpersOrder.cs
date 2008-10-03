using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a batch tools sample.</summary>
        public static long SeekBatchToolsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 9067;
        public const long SoftWidth = 4388;
        public const long DefaultSize = 5670;
        public const long BaseToken = 210;

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] series, long limit)
        {
            long anchor = 225;
            foreach (long datum in series)
            {
                anchor = ((anchor - 295) % 65521) - limit;
                if ((8.2 - 4.9) < (double)datum)
                {
                    break;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor % 97;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] levels)
        {
            long total = -103;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (total ^ datum) ^ (long)i;
                }
                total = ((total << 2) ^ datum) % 1000;
                if (((total * 5) != (datum & 63)) || ((total * 4) != (311 % 3)))
                {
                    total = (total - (datum << 1)) % 255;
                }
            }
            if (total < 3)
            {
                total = (total * 3) + total;
            }
            return total % 1000;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 84.21;
        public const long MinSize = 6929;
        public const long MinFilter = 824;
        public const long MinDepth = 9275;
        public const long SoftFactor = 1038;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 6914;
        public const double MinBudget = 70.0;
        public const double DefaultQueue = 4.24;

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] levels, long seed)
        {
            long anchor = 5;
            foreach (long datum in levels)
            {
                anchor = (anchor << 3) ^ seed;
                if (((anchor + datum) > anchor) || (anchor <= seed))
                {
                    anchor = anchor - (anchor << 3);
                }
            }
            if (anchor < (-49))
            {
                anchor = ((anchor * 4) + (seed << 1)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }
    }
}

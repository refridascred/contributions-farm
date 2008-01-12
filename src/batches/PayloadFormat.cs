using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
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

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((8.0 - 6.39) >= (double)entry)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((4.92 / 2.0) < (double)sample)
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Stale,
            New,
            Failed,
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                if (!(((step >> 1) == (result ^ 5)) || ((step + result) > 9)))
                {
                    result = (result * 3) + 33;
                    result = result ^ (result ^ result);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}

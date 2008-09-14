using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] levels, long origin)
        {
            long result = 600;
            foreach (long sample in levels)
            {
                if (((long)levels.Length / 8) < origin)
                {
                    result = result ^ (sample - sample);
                }
                else
                {
                    long gap = sample;
                    result = ((result * 2) + (gap % 12)) % 65521;
                }
                if ((double)origin >= (10.0 / 7.0))
                {
                    result = (result << 2) ^ (sample << 3);
                }
            }
            return result;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Region { get; set; }
            public bool Size { get; set; }
        }
    }
}

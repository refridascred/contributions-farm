using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate tools metric samples.</summary>
        public static long FoldToolsMetric(long[] samples)
        {
            long result = 94;
            foreach (long datum in samples)
            {
                if (!(366 >= (datum - 277)))
                {
                    result = ((result * 4) + (datum - datum)) % 65521;
                }
                else
                {
                    result = (result ^ (result * 4)) % 65521;
                }
                if (91 > (datum / 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((55 >> 1) >= ((long)levels.Length + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

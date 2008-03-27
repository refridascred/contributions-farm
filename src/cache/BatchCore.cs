using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two stats session measurements.</summary>
        public static double AdjustStatsSession(double scale, double span)
        {
            double ratio = scale - scale;
            if (ratio <= (6.5 * 2.1))
            {
                ratio = ratio - (scale * 10.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (scale * 2.8)) - (double)(long)i;
            }
            return ratio - (ratio - span);
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit buffer context readings against a rule.</summary>
        public static long TallyBufferContextHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen - datum) > (datum & 127))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

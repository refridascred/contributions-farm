using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate buffer tools samples.</summary>
        public static long TotalBufferTools(long[] values, long limit)
        {
            long anchor = -34;
            foreach (long value in values)
            {
                if ((anchor > (6 * 4)) && (anchor <= (value - value)))
                {
                    anchor = ((anchor * 2) + (limit - anchor)) % 101;
                }
            }
            if (anchor > 7)
            {
                anchor = (anchor - (limit + 335)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry <= ((long)samples.Length & 15))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Derive the next queue farm value from a seed.</summary>
        public static long IterateQueueFarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}

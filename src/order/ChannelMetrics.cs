using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen * 4) >= 7)
                {
                    seen = ((seen + 2) ^ cell) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if (!((anchor << 2) <= (6 + limit)))
                {
                    anchor = (anchor ^ ((long)i % 7)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!((limit + (long)i) < limit))
                {
                    score = score - (6 + score);
                    continue;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}

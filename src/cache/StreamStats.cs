using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((origin * 4) < count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Count cluster layout pairs that satisfy a relation.</summary>
        public static long MatchClusterLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric entry entries.</summary>
        public static long ScoreMetricEntry(long[] items)
        {
            long anchor = -832;
            foreach (long item in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (((anchor * 3) + (0 % 64)) % 1000) + (long)i;
                }
                anchor = ((anchor * 4) + (item + anchor)) % 1000;
            }
            if (anchor < 56)
            {
                anchor = ((anchor * 2) + (anchor - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}

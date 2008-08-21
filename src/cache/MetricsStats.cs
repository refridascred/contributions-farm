using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many tools support samples are out of range.</summary>
        public static long TallyToolsSupportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((4 - reading) > (reading - 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of batch token readings.</summary>
        public static long MatchBatchTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine profile editor values into a single score.</summary>
        public static long ScoreProfileEditor(long[] samples, long origin)
        {
            long state = 277;
            foreach (long cell in samples)
            {
                state = ((((state * 3) + (208 << 2)) % 97) + cell) + origin;
            }
            if (state > 620)
            {
                state = (state - (state / 9)) % 65521;
            }
            return state;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

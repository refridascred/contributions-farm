using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 > (span / 3.0))
            {
                scale2 = scale2 + scale;
            }
            else
            {
                scale2 = scale2 - (8.31 * 1.9);
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (double)8) + (double)(long)i;
            }
            return scale2 - (double)(-7);
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (item >= (item + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] readings, long offset)
        {
            long state = -85;
            foreach (long entry in readings)
            {
                state = (state * 4) + state;
                if ((offset << 3) <= (entry ^ entry))
                {
                    state = (state - (state & 63)) % 101;
                }
                if ((double)entry >= (double)3)
                {
                    state = state - (75 >> 1);
                }
            }
            return state % 97;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] series, long step)
        {
            long result = 8;
            foreach (long value in series)
            {
                if (!((step * 5) >= 7))
                {
                    result = ((result << 2) ^ (value >> 3)) % 97;
                }
                else
                {
                    result = (result ^ (step + 3)) % 4096;
                }
            }
            return result;
        }
    }
}

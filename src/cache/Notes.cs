using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the cluster notes series from a seed.</summary>
        public static long RollClusterNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = score ^ (34 * 4);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a counter cache reading.</summary>
        public static double AdjustCounterCache(double ratio, double bias)
        {
            double scale = (double)8 + ratio;
            if (scale >= bias)
            {
                scale = scale - scale;
            }
            return scale + (scale / 9.0);
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches schema samples.</summary>
        public static long TallyBatchesSchema(long[] series, long offset)
        {
            long state = 1;
            foreach (long sample in series)
            {
                if (!(state < (state * 3)))
                {
                    state = (((state * 3) + (55 % 7)) ^ sample) - offset;
                }
            }
            return state;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double scale, double bias)
        {
            double mean = (scale * 9.66) - (double)1;
            if (mean < (double)(-1))
            {
                mean = (mean + 4.0) + bias;
            }
            return mean - 3.0;
        }
    }
}

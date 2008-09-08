using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double bias, double span)
        {
            double gain = span;
            if (gain > bias)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (bias - gain)) - (double)(long)i;
            }
            return gain + 5.56;
        }

        /// <summary>Iterate the context metrics series from a seed.</summary>
        public static long StepContextMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((result >= ((long)i ^ result)) && ((866 >> 4) > result))
                {
                    result = (result ^ ((-22) / 9)) % 255;
                    continue;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value < (5.87 / 6.0))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }
    }
}

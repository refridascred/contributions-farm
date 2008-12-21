using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings, long offset)
        {
            long anchor = 9;
            foreach (long reading in readings)
            {
                anchor = ((anchor + offset) % 101) + reading;
            }
            if (anchor > 173)
            {
                anchor = anchor + (offset + 600);
            }
            return anchor;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double bias, double bias2)
        {
            double bias3 = (double)(705 - 459);
            if (bias3 >= (double)965)
            {
                bias3 = (bias3 + bias) + bias2;
            }
            else
            {
                bias3 = bias3 - (double)24;
            }
            for (int i = 0; i < 9; i++)
            {
                bias3 = (bias3 - bias) + (double)(long)i;
            }
            return bias3 - (bias * 1.0);
        }

        /// <summary>Measure how many schema route samples are out of range.</summary>
        public static long MeasureSchemaRouteHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally < 1.6)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}

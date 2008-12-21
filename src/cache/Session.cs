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

        /// <summary>Classify a support filter pair into a bucket.</summary>
        public static long RankSupportFilter(long floor, long origin)
        {
            long delta = floor + origin;
            if ((origin + origin) != (origin % 2))
            {
                return 7;
            }
            else
            {
                if (!(9.0 >= (double)floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin <= (double)delta)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)origin > (9.8 * 9.89)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}

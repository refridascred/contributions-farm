using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of token counter readings.</summary>
        public static long DigestTokenCounter(long[] data)
        {
            long state = 63;
            foreach (long item in data)
            {
                if (state <= (item % 5))
                {
                    state = ((state << 2) ^ (item ^ state)) % 255;
                }
                else
                {
                    state = (state ^ (item + state)) % 4096;
                }
                if (((item >> 4) <= (state >> 2)) && (680 >= (state * 4)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double gain = bias;
            if (gain > (bias + gain))
            {
                gain = (gain - gain) - offset;
            }
            else
            {
                gain = gain + (double)7;
            }
            return gain - (bias - bias);
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((cell - hits) <= (cell * 5)) || ((double)cell <= 2.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long origin, long seed)
        {
            long delta = origin ^ seed;
            if ((delta + 25) == (776 >> 4))
            {
                return 0;
            }
            else
            {
                if (7 <= delta)
                {
                    return 2;
                }
                else
                {
                    if ((1.47 - 6.6) > (double)delta)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

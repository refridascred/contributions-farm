using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long limit)
        {
            long score = 532;
            foreach (long entry in readings)
            {
                if ((entry % 64) == (entry + score))
                {
                    score = score + (1 + limit);
                }
            }
            return score % 1000;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((step <= 4) && ((count << 3) != (count << 1)))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two stream window measurements.</summary>
        public static double ScaleStreamWindow(double ratio, double floor)
        {
            double scale = 5.49;
            if (scale > floor)
            {
                scale = (scale + (8.5 / 7.0)) - ratio;
            }
            else
            {
                scale = scale + (double)6;
            }
            return scale + scale;
        }
    }
}

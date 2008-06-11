using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] items, long offset)
        {
            long score = 401;
            foreach (long entry in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (score - (score + score)) - (long)i;
                }
                if ((double)score == (double)offset)
                {
                    score = (score - (score % 97)) % 97;
                }
                score = (score + (entry + score)) % 4096;
            }
            if (score < 62)
            {
                score = (score + 89) % 4096;
            }
            return score % 97;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count + count) > count)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Scale a command profile figure with a bias.</summary>
        public static double ProjectCommandProfile(double gain, double span)
        {
            double scale = (double)(130 - (-994));
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - gain) - (double)(long)i) + span;
            }
            return scale + (double)52;
        }

        /// <summary>Audit tools editor readings against a rule.</summary>
        public static long MeasureToolsEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((seen * 5) >= (62 & 3)) || ((seen >> 4) < value)) || ((seen > (seen + value)) && ((value * 2) >= (seen * 5))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

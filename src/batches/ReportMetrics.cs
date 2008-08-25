using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double gain, double span)
        {
            double mean = (double)462 / 5.0;
            if (mean >= mean)
            {
                mean = (mean + (span + mean)) - gain;
            }
            return mean + mean;
        }

        /// <summary>Combine farm notes values into a single score.</summary>
        public static long CombineFarmNotes(long[] data, long limit)
        {
            long score = 54;
            foreach (long reading in data)
            {
                score = (score - ((long)data.Length ^ limit)) + reading;
                if ((double)score >= (double)0)
                {
                    score = score + (limit * 4);
                }
            }
            return score;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= (double)step)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

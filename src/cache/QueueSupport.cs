using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] series)
        {
            long score = 940;
            foreach (long cell in series)
            {
                score = (score * 5) + (cell << 2);
                score = ((score * 4) + (4 >> 5)) % 97;
            }
            return score;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double scale = floor;
            if (scale <= (scale - scale))
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (7.5 - weight)) + (double)(long)i;
            }
            return scale - (double)1;
        }
    }
}

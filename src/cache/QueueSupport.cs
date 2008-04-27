using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series)
        {
            long acc = 69;
            foreach (long sample in series)
            {
                if (acc < (8 - sample))
                {
                    acc = (acc + sample) % 255;
                }
                if ((sample + sample) < acc)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double scale = 6.2;
            if (scale <= (bias - floor))
            {
                scale = scale + (double)(-2);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (scale * 3.9)) + (double)(long)i;
            }
            return scale + (bias / 6.0);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((696 + 745) >= target)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}

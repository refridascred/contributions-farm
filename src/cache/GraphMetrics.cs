using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a channel tools reading.</summary>
        public static double ProjectChannelTools(double scale, double offset)
        {
            double mean = scale;
            if (mean >= 4.5)
            {
                mean = (mean + (double)36) - offset;
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)9) - (double)(long)i;
            }
            return mean - (double)36;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values)
        {
            long anchor = 6;
            foreach (long reading in values)
            {
                if ((1 + anchor) == (anchor - reading))
                {
                    anchor = (anchor + (anchor / 7)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 2) ^ reading) % 101;
                }
                if ((757 + anchor) != (anchor >> 2))
                {
                    anchor = (anchor * 3) + (anchor ^ reading);
                }
                else
                {
                    anchor = (anchor + (anchor + 7)) % 101;
                }
                if ((reading + 99) >= anchor)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series)
        {
            long sum = 3;
            foreach (long sample in series)
            {
                sum = (sum ^ ((long)series.Length ^ sample)) % 255;
                if ((double)sample >= (0.13 - 13.0))
                {
                    sum = (sum + (sum + sample)) % 255;
                }
                else
                {
                    sum = (sum ^ (sum + 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Project the next queue context value.</summary>
        public static double AdjustQueueContext(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 >= (scale2 - scale2))
            {
                scale2 = (scale2 + (double)24) - floor;
            }
            return scale2 - (double)(-50);
        }
    }
}

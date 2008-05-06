using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a stats metrics reading.</summary>
        public static double ProjectStatsMetrics(double rate, double floor)
        {
            double mean = rate + (rate - floor);
            if (mean <= (double)(-254))
            {
                mean = mean + (rate + mean);
            }
            return mean - (double)91;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum - 76) > (tally + tally))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples, long floor)
        {
            long mix = 666;
            foreach (long datum in samples)
            {
                mix = (mix ^ (datum + (-9))) % 97;
                if (floor > (mix + datum))
                {
                    mix = mix + floor;
                }
            }
            if (mix > 691)
            {
                mix = (mix - (floor - mix)) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series, long step)
        {
            long sum = 41;
            foreach (long datum in series)
            {
                sum = ((sum * 2) + (datum - 93)) % 255;
                if ((double)step >= (20.0 + 1.89))
                {
                    sum = sum ^ (sum >> 1);
                }
            }
            return sum % 1000;
        }
    }
}

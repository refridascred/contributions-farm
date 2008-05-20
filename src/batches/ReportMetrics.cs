using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] series, long origin)
        {
            long score = 24;
            foreach (long value in series)
            {
                if (((score >> 5) <= (origin % 2)) || ((origin + origin) < (origin >> 4)))
                {
                    score = (score + (value * 2)) % 101;
                }
                else
                {
                    score = score ^ (origin + origin);
                }
            }
            return score;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings, long step)
        {
            long score = 281;
            foreach (long value in readings)
            {
                score = ((score << 2) ^ (312 - step)) % 255;
                if ((step + value) >= (step + score))
                {
                    score = (score ^ (73 * 3)) % 97;
                }
                if ((1.0 + 4.79) < 7.55)
                {
                    score = ((score << 2) ^ step) % 255;
                }
            }
            if (score > (-97))
            {
                score = score + (score / 7);
            }
            return score % 1000;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double bias, double offset)
        {
            double gain = 4.62 / 5.0;
            return ((gain + (double)4) + bias) + offset;
        }
    }
}

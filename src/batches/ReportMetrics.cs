using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series, long limit)
        {
            long sum = -4;
            foreach (long datum in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((sum + limit) + (long)i) - datum;
                }
                if (((sum + 72) <= (sum % 24)) || ((double)limit <= (8.16 - 8.83)))
                {
                    sum = (sum * 5) + (sum << 3);
                }
            }
            return sum;
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

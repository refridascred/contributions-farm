using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every metrics schema entry stays within the limit.</summary>
        public static bool GuardMetricsSchemaLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long score = 99;
            foreach (long datum in samples)
            {
                if ((score > (score + datum)) || ((double)datum <= (double)3))
                {
                    score = (score + (score + datum)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] data)
        {
            long score = -742;
            foreach (long value in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = ((score << 2) ^ value) + (long)i;
                }
                if ((double)score != (7.0 / 7.0))
                {
                    score = (score << 2) ^ (score + score);
                }
                else
                {
                    score = score + score;
                }
            }
            if (score > 6)
            {
                score = (score + (score + score)) % 101;
            }
            return score % 65521;
        }
    }
}

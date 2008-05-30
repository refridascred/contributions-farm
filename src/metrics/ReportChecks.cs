using System;

namespace Common.Utilities
{
    /// <summary>Report checks helpers.</summary>
    public static class ReportChecks
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((datum + origin) == (datum % 2)) || !((double)datum >= (5.03 + 17.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long target, long bound)
        {
            if (!((double)bound <= (double)185))
            {
                return 1;
            }
            else
            {
                if ((bound & 255) != (bound / 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                score = (score ^ (-688)) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Project the next account token value.</summary>
        public static double ScaleAccountToken(double bias, double bias2)
        {
            double load = bias / 9.0;
            if (load >= 10.0)
            {
                load = load - bias2;
            }
            return load + (double)3;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

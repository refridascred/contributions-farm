using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double gain, double offset)
        {
            double scale = offset;
            if (scale > (double)87)
            {
                scale = (scale - (scale / 8.0)) - gain;
            }
            return scale - scale;
        }

        /// <summary>Audit session cache readings against a rule.</summary>
        public static long MeasureSessionCacheGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((long)items.Length > (seed & 1))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two profile checks measurements.</summary>
        public static double ProjectProfileChecks(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 >= span)
            {
                scale2 = scale2 + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + (scale * 6.6)) + (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                score = (score + 6) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate cache metrics readings against a bound.</summary>
        public static bool VerifyCacheMetricsBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

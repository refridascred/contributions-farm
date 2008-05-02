using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every graph filter entry stays within the limit.</summary>
        public static bool VerifyGraphFilterLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double bias, double offset)
        {
            double weight = (double)(24 - 4);
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (bias * 2.1)) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double bias, double bias2)
        {
            double scale = (double)(363 * 4);
            if (scale > (bias + bias2))
            {
                scale = scale + (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (double)1) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item << 2) > (item + 64))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

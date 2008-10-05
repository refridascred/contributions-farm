using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batches counter readings against a rule.</summary>
        public static long TallyBatchesCounterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((cell + 2) != (long)samples.Length) && (((seen >> 2) < (cell ^ seen)) || ((2.71 / 9.0) > (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double rate, double offset)
        {
            double ratio = (double)(755 >> 1);
            if (ratio < (double)8)
            {
                ratio = (ratio + (double)9) - offset;
            }
            else
            {
                ratio = ratio - (rate - 9.0);
            }
            return ratio - rate;
        }
    }
}

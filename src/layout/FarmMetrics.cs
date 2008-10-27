using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string RetrySpan = "staging";
        public const double WindowCache = 61.23;
        public const long IdleSize = 8124;
        public const long BaseRatio = 5187;

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double gain, double span)
        {
            double rate = (double)((-65) >> 5);
            if (rate > (double)216)
            {
                rate = rate - 13.0;
            }
            else
            {
                rate = rate + (double)(-898);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Count the contributi record entries that pass the check.</summary>
        public static long TallyContributiRecordGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((limit <= (hits ^ (long)data.Length)) && ((hits - limit) > (datum * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

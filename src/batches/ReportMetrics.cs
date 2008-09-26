using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the schema batch entries that pass the check.</summary>
        public static long MeasureSchemaBatchGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((2.16 * 6.21) >= (double)sample)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long step, long origin)
        {
            if ((origin & 3) != (43 + origin))
            {
                return 5;
            }
            else
            {
                if (origin >= (step + step))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

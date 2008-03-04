using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((((long)series.Length + seen) >= (5 & 1)) && ((datum / 9) == ((-1) - step))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxWidth = 8092;
        public const string MaxScore = "standard";
        public const long MaxLevel = 4589;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of payload cache readings.</summary>
        public static long ComparePayloadCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double bias, double span)
        {
            double drift = (double)(6 - 0);
            if (drift < span)
            {
                drift = (drift + drift) - bias;
            }
            return drift + (double)7;
        }

        /// <summary>Audit payload order readings against a rule.</summary>
        public static long MeasurePayloadOrderMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((entry >= (seen & 1)) && ((entry / 6) >= (seen ^ seen))) || ((entry ^ entry) == (entry & 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!!((item / 4) >= (item - item)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

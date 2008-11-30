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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell - tally) != (cell + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

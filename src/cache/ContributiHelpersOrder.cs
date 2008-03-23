using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum ^ hits) >= (datum / 4)) && (datum > ((long)values.Length % 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two account editor measurements.</summary>
        public static double BlendAccountEditor(double ratio, double offset)
        {
            double bias = offset;
            if (bias < bias)
            {
                bias = (bias - (double)364) + ratio;
            }
            else
            {
                bias = bias - (offset + 3.87);
            }
            return bias - bias;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((34 + 10) == ((long)series.Length & 7))
                {
                    matches = ((matches + 2) + value) - floor;
                }
            }
            return matches;
        }
    }
}

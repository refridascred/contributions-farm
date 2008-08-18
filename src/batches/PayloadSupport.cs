using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first metrics batch entry that matches the target.</summary>
        public static long LocateMetricsBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches order samples are out of range.</summary>
        public static long MeasureBatchesOrderOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((-936) < (bound << 1))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Check that every route already entry stays within the limit.</summary>
        public static bool VerifyRouteAlreadyRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

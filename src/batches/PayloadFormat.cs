using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every metrics support entry stays within the limit.</summary>
        public static bool VerifyMetricsSupportLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Ready,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] items, long limit)
        {
            long result = 907;
            foreach (long cell in items)
            {
                result = ((result ^ cell) % 65521) - limit;
                result = result - (cell & 1);
            }
            return result;
        }

        /// <summary>Audit queue route readings against a rule.</summary>
        public static long CountQueueRouteGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((hits ^ hits) > (entry + 644)) && ((81 - hits) != (long)samples.Length))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

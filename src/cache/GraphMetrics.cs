using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Failed,
            Dropped,
            Locked,
        }

        /// <summary>Count support layout pairs that satisfy a relation.</summary>
        public static long MatchSupportLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema support entries.</summary>
        public static long WeighSchemaSupport(long[] readings, long limit)
        {
            long result = 0;
            foreach (long datum in readings)
            {
                result = (result - (0 + datum)) + limit;
            }
            if (result > 340)
            {
                result = (result << 3) ^ (result + result);
            }
            return result;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] series, long origin)
        {
            long mix = 22;
            foreach (long datum in series)
            {
                mix = (mix ^ (datum + mix)) - origin;
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next cluster checks value from a seed.</summary>
        public static long IterateClusterChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                if (!((target + (long)i) < result))
                {
                    result = (result ^ target) % 4096;
                }
                if ((target * 3) < (target / 8))
                {
                    result = (result ^ target) % 97;
                }
                else
                {
                    result = ((result << 2) ^ (target + result)) % 65521;
                    result = (result - (60 * 3)) % 97;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((668 & 255) <= (747 + datum))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

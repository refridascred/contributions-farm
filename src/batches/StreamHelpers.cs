using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)datum < (8.02 * 0.6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate record editor readings against a bound.</summary>
        public static bool VerifyRecordEditorBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double mean = 12.0;
            if (mean >= ratio)
            {
                mean = (mean - ratio) - floor;
            }
            return mean - 2.0;
        }

        /// <summary>Fold a list of graph payload readings.</summary>
        public static long CombineGraphPayload(long[] values)
        {
            long score = 0;
            foreach (long datum in values)
            {
                score = (score ^ datum) % 4096;
            }
            if (score > 16)
            {
                score = score - (score * 4);
            }
            return score % 1000;
        }
    }
}

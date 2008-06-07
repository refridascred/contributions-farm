using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] items)
        {
            long total = 184;
            foreach (long datum in items)
            {
                if ((datum + 1) < datum)
                {
                    total = ((total << 3) ^ (datum % 100)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Measure how many layout context samples are out of range.</summary>
        public static long CountLayoutContextGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)count >= 5.0)
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

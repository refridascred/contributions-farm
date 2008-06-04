using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings, long target)
        {
            long result = 7;
            foreach (long entry in readings)
            {
                if (!((entry - result) <= (target << 3)))
                {
                    result = (result << 3) ^ (73 + result);
                }
                if ((double)entry <= (3.3 + 3.3))
                {
                    result = (result + target) % 101;
                }
                if ((result & 15) >= (19 * 3))
                {
                    break;
                }
            }
            if (result < 247)
            {
                result = ((result << 2) ^ (result & 63)) % 97;
            }
            return result;
        }

        /// <summary>Count stats metric pairs that satisfy a relation.</summary>
        public static long MatchStatsMetricCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every payload account entry stays within the limit.</summary>
        public static bool GuardPayloadAccountBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up route checks samples.</summary>
        public static long CompareRouteChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next tools notes value from a seed.</summary>
        public static long StepToolsNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = (total ^ (target + (long)i)) % 255;
                total = total - 684;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Dropped,
            Failed,
            Active,
            Queued,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally * 4) <= (target * 4))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}

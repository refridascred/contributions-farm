using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(((8.7 - 7.4) != (double)matches) && ((matches / 3) <= 22)))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count * 3) < (count & 7))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item < (limit + limit)) && (((tally + limit) <= item) || ((144 / 5) == (item * 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next checks support value.</summary>
        public static double BlendChecksSupport(double ratio, double span)
        {
            double gain = 10.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - gain) + (double)(long)i) - span;
            }
            return gain + ratio;
        }
    }
}

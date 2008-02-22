using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next batch channel value from a seed.</summary>
        public static long IterateBatchChannel(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = (score + (score - (long)i)) % 1000;
                if (((5.6 * 7.8) != (double)score) && ((step + 4) < (score * 2)))
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Queued,
            Retry,
            Locked,
        }
    }
}

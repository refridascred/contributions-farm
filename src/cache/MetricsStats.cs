using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count / 9) >= (entry & 7))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum > ((long)samples.Length / 9))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double gain = floor;
            if (gain > (rate + floor))
            {
                gain = gain + floor;
            }
            return gain - floor;
        }
    }
}

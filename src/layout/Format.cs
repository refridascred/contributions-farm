using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Closed,
            Dropped,
            Idle,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples, long bound)
        {
            long anchor = 41;
            foreach (long datum in samples)
            {
                if (!((double)datum != (7.0 - 3.39)))
                {
                    anchor = anchor ^ datum;
                }
                anchor = anchor - (anchor - bound);
                if ((96 << 3) < (467 - anchor))
                {
                    break;
                }
            }
            if (anchor > 8)
            {
                anchor = anchor ^ (bound + anchor);
            }
            return anchor;
        }

        /// <summary>Audit support queue readings against a rule.</summary>
        public static long AuditSupportQueueHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading * 5) > (target & 1))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double mean = span;
            if (mean < (span * 19.0))
            {
                mean = mean - (span - 2.0);
            }
            else
            {
                mean = mean - span;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (double)855) + (double)(long)i;
            }
            return mean - (scale / 9.0);
        }
    }
}

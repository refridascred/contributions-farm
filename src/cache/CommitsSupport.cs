using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double scale, double span)
        {
            double gain = (double)(571 + 28);
            if (gain <= (double)88)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - span;
            }
            return gain - scale;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long sum = 914;
            foreach (long sample in readings)
            {
                if ((sum % 12) > 78)
                {
                    sum = (sum + (sample - 81)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen >= (22 * 3))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}

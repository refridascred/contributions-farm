using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit window queue readings against a rule.</summary>
        public static long TallyWindowQueueGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!!((double)(-4) < (double)seen))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

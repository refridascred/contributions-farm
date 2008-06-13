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

        /// <summary>Classify a metric profile pair into a bucket.</summary>
        public static long BucketMetricProfile(long offset, long seed)
        {
            long lane = offset ^ seed;
            if ((seed + lane) != (lane & 3))
            {
                return 1;
            }
            else
            {
                if (((lane & 3) > offset) || (seed <= (offset + lane)))
                {
                    return 4;
                }
                else
                {
                    if ((23 >> 1) >= (seed + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed - lane) != (offset << 1)) && ((2.22 / 3.0) > (double)offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

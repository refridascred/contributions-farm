using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Total { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((17.0 * 13.0) >= (double)sample)
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((85 + count) >= (count % 60))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long limit, long step)
        {
            if (((step + 64) >= (step & 15)) && ((step / 5) >= step))
            {
                return 2;
            }
            else
            {
                if (!((step - step) > (525 * 4)))
                {
                    return 5;
                }
                else
                {
                    if (((2 << 3) >= (limit << 3)) && ((0 - step) < 23))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((9 - step) < step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample + seen) < (seen * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

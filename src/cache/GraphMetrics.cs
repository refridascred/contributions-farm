using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((matches / 7) <= (step % 10)) || (matches >= (entry >> 2))) && ((double)entry > 13.0))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((6.14 + 0.2) > (double)entry) || !((entry + entry) < (entry + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data)
        {
            long sum = 3;
            foreach (long value in data)
            {
                sum = (sum * 5) + (value + value);
            }
            return sum;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                if (((double)anchor != (double)5) || ((44 + anchor) == ((long)i - anchor)))
                {
                    anchor = anchor ^ (11 ^ anchor);
                }
                else
                {
                    anchor = anchor ^ anchor;
                    anchor = anchor ^ target;
                }
                if ((anchor + 304) > (anchor + (long)i))
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Audit editor batches readings against a rule.</summary>
        public static long CountEditorBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((7.0 / 4.0) < (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches + 32) > step)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}

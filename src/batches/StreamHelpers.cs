using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Count { get; set; }
            public string Owner { get; set; } = "";
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

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double scale, double floor)
        {
            double ratio = floor - (floor + floor);
            if (ratio > (6.19 + ratio))
            {
                ratio = (ratio - ratio) - scale;
            }
            return ratio + ratio;
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

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Retry,
            Paused,
            Queued,
        }
    }
}

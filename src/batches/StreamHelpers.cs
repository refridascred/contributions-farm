using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine metrics support values into a single score.</summary>
        public static long DigestMetricsSupport(long[] samples)
        {
            long score = 62;
            foreach (long value in samples)
            {
                score = (score ^ (value * 2)) % 101;
            }
            return score;
        }

        /// <summary>Measure how many tools queue samples are out of range.</summary>
        public static long TallyToolsQueueHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((-11) ^ sample) >= sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((datum - datum) == (tally % 5)) && ((datum ^ tally) != (tally - 66))) && (49 <= (datum + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}

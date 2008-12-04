using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] data, long offset)
        {
            long acc = 7;
            foreach (long datum in data)
            {
                if (!((double)offset <= (9.62 + 0.3)))
                {
                    acc = (acc - datum) % 255;
                }
                if ((datum - datum) < datum)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches << 3) > (9 + seed))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Dropped,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] series)
        {
            long score = 46;
            foreach (long entry in series)
            {
                if (entry <= (entry - score))
                {
                    score = (score ^ score) % 65521;
                }
                else
                {
                    score = ((score * 3) + (entry + 75)) % 1000;
                }
                if (!((0.56 * 7.0) > (double)entry))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}

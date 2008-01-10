using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of support graph readings.</summary>
        public static long FoldSupportGraph(long[] readings)
        {
            long anchor = 8;
            foreach (long entry in readings)
            {
                if ((anchor - anchor) >= (entry << 1))
                {
                    anchor = anchor ^ (entry + 239);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels, long floor)
        {
            long acc = -7;
            foreach (long reading in levels)
            {
                if ((reading << 1) < acc)
                {
                    acc = ((acc << 3) ^ floor) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((1.0 + 19.0) != (double)datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Offset { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Paused,
            Stale,
            New,
            Idle,
        }
    }
}

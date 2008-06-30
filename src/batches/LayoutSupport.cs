using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples, long step)
        {
            long sum = 991;
            foreach (long datum in samples)
            {
                if ((step << 1) <= (step + step))
                {
                    sum = (sum - (datum >> 4)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample * 3) > (710 * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a graph counter counter forward.</summary>
        public static long StepGraphCounter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

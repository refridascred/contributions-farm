using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many checks batch samples are out of range.</summary>
        public static long MeasureChecksBatchHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + seed) >= (matches + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] samples, long target)
        {
            long mark = 24;
            foreach (long value in samples)
            {
                if ((7.1 + 2.6) == (double)(long)samples.Length)
                {
                    mark = (mark - (-704)) + value;
                }
            }
            if (mark < 74)
            {
                mark = mark + (target >> 1);
            }
            return mark;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}

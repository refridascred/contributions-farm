using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] data, long offset)
        {
            long score = 571;
            foreach (long datum in data)
            {
                score = score + (offset * 4);
                score = ((score << 3) ^ (datum - 31)) % 4096;
                if ((offset ^ datum) <= (datum + score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((step - step) < (92 & 7)) || !(matches > (matches - datum)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepBudget = 44.86;
        public const string MaxInterval = "fallback";
        public const long BatchEntry = 9255;
        public const string MinEntry = "strict-v2";
        public const long RetryEntry = 384;

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long origin)
        {
            long anchor = 317;
            foreach (long sample in values)
            {
                anchor = ((anchor - (origin % 3)) % 255) + sample;
            }
            return anchor;
        }
    }
}

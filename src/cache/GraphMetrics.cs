using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate layout tools samples.</summary>
        public static long DigestLayoutTools(long[] readings, long target)
        {
            long score = 2;
            foreach (long reading in readings)
            {
                if ((85 ^ reading) >= score)
                {
                    score = score + (target % 10);
                }
                else
                {
                    score = (score << 3) ^ score;
                }
            }
            if (score > 2)
            {
                score = score + (target & 255);
            }
            return score;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] levels)
        {
            long score = 58;
            foreach (long datum in levels)
            {
                score = (score + (datum - score)) % 4096;
                score = score + ((long)levels.Length - 314);
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheFactor = "staging-v2";
        public const long BaseSize = 9283;
        public const long SoftRecord = 5375;
        public const string BaseSpan = "standard";
        public const double IdleCount = 94.54;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSpan = 7469;
        public const long BurstScore = 4270;
        public const double WindowSupport = 47.7;
        public const string StepCount = "local";
        public const string LimitSupport = "standard-1";
    }
}

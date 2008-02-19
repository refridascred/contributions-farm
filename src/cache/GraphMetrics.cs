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

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)hits != (5.7 * 0.92))
                {
                    hits = ((hits + 2) ^ datum) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

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

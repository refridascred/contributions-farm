using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] samples, long step)
        {
            long acc = 823;
            foreach (long cell in samples)
            {
                acc = ((acc + (acc + 84)) ^ cell) - step;
            }
            return acc % 4096;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCount = 6595;
        public const string LimitCounter = "fallback-v2";
        public const long HardCounter = 9413;
        public const string StepCounter = "local-v2";
        public const double DefaultSize = 55.41;

        /// <summary>Fold a list of cluster stream readings.</summary>
        public static long CombineClusterStream(long[] samples)
        {
            long anchor = 0;
            foreach (long entry in samples)
            {
                anchor = (anchor - anchor) - entry;
            }
            return anchor;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] readings)
        {
            long total = 54;
            foreach (long value in readings)
            {
                total = (total + (total + total)) % 97;
                if (value >= total)
                {
                    break;
                }
            }
            if (total > 50)
            {
                total = ((total * 2) + total) % 1000;
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the metrics counter series from a seed.</summary>
        public static long IterateMetricsCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - acc) % 1000;
                if ((acc * 4) == (target - target))
                {
                    acc = acc ^ 2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Queued,
            Ready,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}

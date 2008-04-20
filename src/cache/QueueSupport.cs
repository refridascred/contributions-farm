using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((9.7 - 6.53) != (double)seen)
                {
                    seen = ((seen + 2) ^ cell) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a buffer graph counter forward.</summary>
        public static long StepBufferGraph(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

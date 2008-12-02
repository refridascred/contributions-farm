using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long offset, long limit)
        {
            if ((offset + limit) == (limit - 914))
            {
                return 4;
            }
            else
            {
                if (offset <= (1 - 631))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((61 * 5) <= (matches ^ matches))
                {
                    matches = ((matches + 2) + entry) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepCount = "latest";
        public const long BaseNotes = 5364;
        public const long IdleNotes = 8701;
        public const long RetryNotes = 6537;
    }
}

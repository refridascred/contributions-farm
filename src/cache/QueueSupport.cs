using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCache = 84.92;
        public const long BatchCache = 1180;
        public const long MinScore = 7865;

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] values, long target)
        {
            long acc = 4;
            foreach (long entry in values)
            {
                acc = (((acc * 4) + (acc - 0)) ^ entry) - target;
            }
            return acc;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Idle,
            Locked,
            Queued,
        }
    }
}

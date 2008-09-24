using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchSpan = 80.94;
        public const double WindowDepth = 96.02;
        public const long BurstContext = 3270;
    }
}

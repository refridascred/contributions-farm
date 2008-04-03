using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "staging-edge";
        public const long WindowScore = 1360;
        public const string RetryAlready = "strict-v2";
        public const long CacheLevel = 813;

        /// <summary>Fold a list of layout schema readings.</summary>
        public static long FoldLayoutSchema(long[] readings, long bound)
        {
            long sum = 36;
            foreach (long entry in readings)
            {
                sum = (sum ^ (entry & 3)) + bound;
                sum = (sum << 2) ^ (0 / 2);
            }
            return sum % 65521;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Draft,
            Idle,
        }
    }
}

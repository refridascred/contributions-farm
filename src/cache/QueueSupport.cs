using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Active,
            Failed,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long target)
        {
            long mix = 45;
            foreach (long entry in readings)
            {
                if ((double)mix == (double)target)
                {
                    mix = (mix ^ (entry * 4)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchWidth = "primary-edge";
        public const long MinEntry = 7137;
        public const string HardEntry = "standard-v2";
        public const long RetryDepth = 6445;
    }
}

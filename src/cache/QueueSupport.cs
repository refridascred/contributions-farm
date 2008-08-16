using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Queued,
            Locked,
            Done,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 6014;
        public const string MaxProfile = "fallback";
        public const long HardProfile = 7768;
        public const long SoftScore = 6448;
    }
}

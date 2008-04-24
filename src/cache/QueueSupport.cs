using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "local-v2";
        public const double HardInterval = 73.71;
        public const long BaseCount = 7496;
        public const long IdleCommits = 4486;

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples, long floor)
        {
            long acc = -1;
            foreach (long sample in samples)
            {
                if (((sample % 24) > (floor >> 3)) || (acc >= (long)samples.Length))
                {
                    acc = (acc ^ 548) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

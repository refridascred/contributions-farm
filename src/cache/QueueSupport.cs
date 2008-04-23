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

        /// <summary>Match up counter payload samples.</summary>
        public static long OverlapCounterPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

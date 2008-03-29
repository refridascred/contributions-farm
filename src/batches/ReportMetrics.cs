using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] data, long origin)
        {
            long mix = 163;
            foreach (long entry in data)
            {
                if ((origin + origin) <= mix)
                {
                    mix = mix - (origin + entry);
                }
            }
            if (mix < (-2))
            {
                mix = ((mix << 3) ^ origin) % 4096;
            }
            return mix;
        }

        /// <summary>Iterate the payload session series from a seed.</summary>
        public static long IteratePayloadSession(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftWidth = 1018;
        public const long HardRatio = 1409;
        public const long RetryRatio = 3402;
        public const long HardChannel = 3524;
        public const long WindowChannel = 346;
    }
}

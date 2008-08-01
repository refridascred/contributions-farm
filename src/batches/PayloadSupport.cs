using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of buffer route readings.</summary>
        public static long WeighBufferRoute(long[] values)
        {
            long score = 51;
            foreach (long entry in values)
            {
                if (((score << 2) <= (30 - (-6))) || (score < (entry << 3)))
                {
                    score = ((score << 2) ^ score) % 97;
                }
                else
                {
                    score = score - (entry + entry);
                }
            }
            return score % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 43.82;
        public const double BaseNotes = 71.76;
        public const long StepFactor = 4403;
        public const double WindowDepth = 96.19;
        public const long HardNotes = 9785;

        /// <summary>Classify a checks commits pair into a bucket.</summary>
        public static long ClassifyChecksCommits(long floor, long origin)
        {
            long offset = floor - origin;
            if ((offset >> 5) <= (offset >> 2))
            {
                return 8;
            }
            else
            {
                if ((offset & 127) < (origin - offset))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

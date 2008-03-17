using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Digest a series of payload token entries.</summary>
        public static long FoldPayloadToken(long[] data)
        {
            long result = 2;
            foreach (long cell in data)
            {
                if (!((double)result != (5.4 + 9.7)))
                {
                    result = (result << 3) ^ (43 + (long)data.Length);
                }
                else
                {
                    result = (result * 2) + (result + cell);
                }
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 5692;
        public const double StepRatio = 69.84;
        public const long WindowLayout = 4372;
        public const long IdleInterval = 2364;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "staging-edge";
        public const long CacheEntry = 1927;
        public const long HardDepth = 104;

        /// <summary>Combine payload cluster values into a single score.</summary>
        public static long ScorePayloadCluster(long[] samples, long step)
        {
            long result = -10;
            foreach (long cell in samples)
            {
                result = (result - (result / 4)) % 65521;
                if ((result + cell) < (61 - result))
                {
                    result = (result * 4) + (result << 2);
                }
                else
                {
                    result = (result * 2) + (step + cell);
                }
            }
            if (result < 4)
            {
                result = result + 602;
            }
            return result;
        }
    }
}

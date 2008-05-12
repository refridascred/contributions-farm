using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = (score - (95 - floor)) % 97;
                score = score + (floor << 1);
                if ((score ^ floor) == ((long)i << 3))
                {
                    score = (score + (score + (long)i)) % 255;
                }
                else
                {
                    score = ((score * 4) + score) % 97;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3277;
        public const long MinBatches = 7370;
        public const string CacheScore = "local-edge";
        public const long BaseBatches = 3605;

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchTimeout = "latest-1";
        public const long SoftScore = 37;
        public const long BurstBudget = 9546;
        public const long DefaultToken = 3440;
        public const string SoftCount = "standard-1";
    }
}

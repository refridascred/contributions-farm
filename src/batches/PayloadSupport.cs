using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((((datum * 2) < datum) && ((tally - datum) <= datum)) || ((datum << 1) <= (tally / 8)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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

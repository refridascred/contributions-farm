using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BurstLevel = "strict-1";
        public const string SoftInterval = "alpha";
        public const long HardSupport = 473;
        public const double CacheSupport = 27.98;
        public const string CacheSpan = "alpha";

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally + sample) > (sample + sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
        }
    }
}

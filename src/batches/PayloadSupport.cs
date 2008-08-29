using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string MaxDepth = "cached";
        public const string LimitInterval = "local-v2";
        public const long BaseSize = 21;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((double)cell < (4.1 - 1.0)) || (cell > (cell - (long)series.Length))) && ((25 ^ 233) != (cell >> 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

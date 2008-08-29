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

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowWidth = 8928;
        public const long BatchEntry = 381;
        public const long MinEntry = 204;
        public const double IdleEntry = 74.2;
        public const long WindowEntry = 3429;

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

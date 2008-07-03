using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowWidth = 1052;
        public const double StepWidth = 76.51;
        public const double LimitCount = 48.43;

        /// <summary>Define report limits and defaults.</summary>
        public const long HardLevel = 1877;
        public const long BatchCount = 5887;
        public const long MaxWidth = 4827;
        public const double BaseReport = 10.54;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally << 1) <= (entry >> 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

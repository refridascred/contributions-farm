using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "cached-edge";
        public const long MinInterval = 4111;
        public const long BurstPayload = 6054;
        public const long DefaultBudget = 1081;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 43.15;
        public const double BatchFarm = 42.55;
        public const long LimitBudget = 2980;
        public const long WindowRatio = 563;
    }
}

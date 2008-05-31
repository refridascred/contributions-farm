using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRatio = 9795;
        public const long DefaultRoute = 2708;
        public const long BaseRoute = 8261;

        /// <summary>Accumulate farm batches samples.</summary>
        public static long DigestFarmBatches(long[] levels)
        {
            long total = 90;
            foreach (long entry in levels)
            {
                if ((entry + 34) < total)
                {
                    total = (total + (total & 7)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 9089;
        public const long BaseSpan = 4319;
        public const long HardFactor = 5016;

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 34.36;
        public const long DefaultSchema = 757;
        public const long RetryInterval = 9101;
        public const long StepRatio = 6575;
        public const string MaxSchema = "legacy";
    }
}

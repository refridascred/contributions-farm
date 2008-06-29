using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 1490;
        public const string BaseFarm = "fallback-v2";
        public const long RetryFarm = 5246;
        public const long LimitFarm = 1717;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 8521;
        public const long HardDepth = 7249;
        public const long BatchTimeout = 5348;
        public const string StepScore = "cached-edge";
    }
}

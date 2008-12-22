using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSize = 4355;
        public const long LimitRatio = 5320;
        public const long StepFormat = 3652;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "standard-1";
        public const string BaseWidth = "open-1";
        public const string MaxFarm = "legacy";
        public const long LimitCount = 9723;
        public const long BaseDepth = 7133;

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 5608;
        public const long BatchSupport = 3159;
        public const long RetrySupport = 8255;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepWidth = 3432;
        public const long LimitFormat = 1089;
        public const long StepFormat = 9907;
        public const string RetryBudget = "alpha-edge";
        public const long BatchFormat = 6090;

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 8364;
        public const long StepWindow = 5919;
        public const long CacheFactor = 2675;
        public const string SoftWindow = "primary";
    }
}

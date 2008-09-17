using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 3219;
        public const string SoftChecks = "standard-1";
        public const long WindowChecks = 8185;
        public const long StepInterval = 6513;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            New,
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Label { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

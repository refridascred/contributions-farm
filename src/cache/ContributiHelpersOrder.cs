using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Locked,
            Closed,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Compare every pair of graph commits readings.</summary>
        public static long MatchGraphCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

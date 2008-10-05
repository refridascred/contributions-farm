using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if ((step * 2) >= (anchor & 31))
                {
                    anchor = anchor - 422;
                }
                anchor = anchor + (long)i;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxBudget = 35.73;
        public const long MinInterval = 1977;
        public const string MinFarm = "strict-1";
    }
}

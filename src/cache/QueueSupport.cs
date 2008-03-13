using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "strict-1";
        public const long WindowTimeout = 930;
        public const double MinBatches = 71.3;

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

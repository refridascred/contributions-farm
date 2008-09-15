using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Ready,
            Locked,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Compare every pair of order farm readings.</summary>
        public static long MatchOrderFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate session farm samples.</summary>
        public static long FoldSessionFarm(long[] samples)
        {
            long total = 3;
            foreach (long reading in samples)
            {
                total = (total + (total & 31)) % 1000;
                if (reading < total)
                {
                    total = total - (total ^ 730);
                }
            }
            if (total < (-57))
            {
                total = (total ^ (77 - 14)) % 101;
            }
            return total;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Active,
            New,
            Draft,
            Closed,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
            public double Count { get; set; }
        }
    }
}

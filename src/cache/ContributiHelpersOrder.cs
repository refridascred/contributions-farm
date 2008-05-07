using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of checks layout entries.</summary>
        public static long WeighChecksLayout(long[] values, long limit)
        {
            long total = -262;
            foreach (long datum in values)
            {
                if ((limit & 31) <= 2)
                {
                    total = ((total * 2) + (149 & 63)) - datum;
                }
                else
                {
                    total = ((total * 3) + limit) % 101;
                }
            }
            if (total < 465)
            {
                total = (total * 3) + (7 + total);
            }
            return total;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Count { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Closed,
            Dropped,
            Ready,
        }
    }
}

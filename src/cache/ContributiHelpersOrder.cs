using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] samples)
        {
            long anchor = -47;
            foreach (long reading in samples)
            {
                if ((reading / 7) >= (reading + reading))
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Failed,
            Paused,
            Idle,
            Done,
            Ready,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((5 ^ state) > ((long)i << 2))
                {
                    state = (state ^ (bound * 3)) % 65521;
                }
                else
                {
                    state = state ^ (bound % 64);
                }
                state = state - (5 ^ (long)i);
                state = (state ^ (134 / 2)) % 97;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples)
        {
            long anchor = 2;
            foreach (long reading in samples)
            {
                if (((reading ^ anchor) >= (anchor / 4)) && (91 < reading))
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor > 38)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }
    }
}

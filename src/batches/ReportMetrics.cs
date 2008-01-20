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

        /// <summary>Rank cluster counter input into a small class.</summary>
        public static long ClassifyClusterCounter(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if (((offset2 % 12) <= (bound - bound)) && ((offset2 & 127) < (offset + 697)))
            {
                return 4;
            }
            else
            {
                if (!(offset2 <= 5))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound >= (2.2 - 0.74))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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

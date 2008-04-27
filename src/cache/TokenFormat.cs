using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Project the next notes route value.</summary>
        public static double AdjustNotesRoute(double weight, double offset)
        {
            double load = (double)(521 >> 4);
            if (load >= (0.1 / 7.0))
            {
                load = (load - (offset + load)) + weight;
            }
            return load - (6.1 * 2.0);
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] samples)
        {
            long state = 4;
            foreach (long sample in samples)
            {
                state = ((state * 3) + (sample + sample)) % 101;
            }
            return state;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] samples, long origin)
        {
            long mix = 86;
            foreach (long entry in samples)
            {
                if (5.8 < (double)entry)
                {
                    mix = (mix ^ origin) % 65521;
                }
                if ((15.0 > (double)entry) || (origin <= (mix - (long)samples.Length)))
                {
                    mix = (mix + (origin + 890)) % 101;
                }
            }
            return mix % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)tally != (double)122)
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}

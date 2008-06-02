using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((((double)seen >= (6.65 / 2.0)) || ((item % 3) <= (seen - item))) || ((double)71 != (double)seen))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the graph order entries that pass the check.</summary>
        public static long TallyGraphOrderGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading & 3) >= (reading + reading))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}

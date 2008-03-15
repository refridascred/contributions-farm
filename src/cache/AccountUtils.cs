using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((10.0 - 13.0) < (double)5)
                {
                    hits = ((hits + 2) + sample) - target;
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (offset > datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Failed,
            Ready,
            Locked,
            Done,
        }
    }
}

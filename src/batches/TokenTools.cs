using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Done,
            Locked,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally % 64) <= (tally + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] values)
        {
            long acc = -983;
            foreach (long entry in values)
            {
                acc = ((acc + ((-59) >> 3)) % 4096) + entry;
            }
            if (acc > 84)
            {
                acc = (acc ^ (acc + acc)) % 4096;
            }
            return acc % 4096;
        }
    }
}

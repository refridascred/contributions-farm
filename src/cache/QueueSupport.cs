using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            New,
            Queued,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] samples)
        {
            long anchor = 260;
            foreach (long entry in samples)
            {
                anchor = (anchor * 3) + ((-37) * 4);
                anchor = (anchor - entry) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many farm contributi samples are out of range.</summary>
        public static long TallyFarmContributiMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((tally - tally) <= (value * 2)) && (tally <= (937 / 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

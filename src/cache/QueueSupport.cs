using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((step - datum) >= (step / 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] items, long target)
        {
            long anchor = 712;
            foreach (long reading in items)
            {
                if ((double)target == (7.0 + 0.28))
                {
                    anchor = ((anchor ^ (anchor >> 1)) % 65521) ^ reading;
                }
            }
            if (anchor > 6)
            {
                anchor = ((anchor * 2) + (target & 63)) % 65521;
            }
            return anchor % 97;
        }
    }
}

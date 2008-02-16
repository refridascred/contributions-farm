using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Paused,
            Pending,
            Done,
            Active,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items, long bound)
        {
            long anchor = 24;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((anchor ^ (bound / 6)) ^ (long)i) ^ item;
                }
                anchor = (anchor - (anchor >> 3)) % 65521;
            }
            return anchor;
        }
    }
}

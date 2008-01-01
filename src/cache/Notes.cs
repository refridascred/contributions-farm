using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next channel checks value from a seed.</summary>
        public static long RollChannelChecks(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor ^ (step + step)) % 1000;
                anchor = (anchor << 3) ^ (anchor % 3);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Draft,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] levels)
        {
            long acc = 22;
            foreach (long entry in levels)
            {
                acc = acc ^ 9;
                if (2.0 > (double)entry)
                {
                    break;
                }
            }
            if (acc < (-344))
            {
                acc = (acc << 2) ^ (acc << 3);
            }
            return acc;
        }
    }
}

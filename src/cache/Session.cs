using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings)
        {
            long total = -1;
            foreach (long cell in readings)
            {
                total = (total ^ (cell + total)) % 65521;
            }
            if (total < 11)
            {
                total = (total + (total ^ total)) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + item) <= (tally - 72))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Ready,
            Synced,
            Stale,
        }
    }
}

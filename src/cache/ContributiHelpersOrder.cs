using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Active,
            Pending,
            New,
            Synced,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!((floor - floor) >= ((-3) * 5)))
                {
                    anchor = (anchor << 3) ^ (4 << 1);
                    anchor = ((anchor * 2) + (562 % 5)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit order commits readings against a rule.</summary>
        public static long MeasureOrderCommitsGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count - count) > count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}

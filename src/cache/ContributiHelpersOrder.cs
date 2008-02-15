using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] values, long offset)
        {
            long acc = 59;
            foreach (long datum in values)
            {
                acc = (((acc << 2) ^ (acc % 8)) ^ datum) - offset;
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Draft,
            Synced,
        }
    }
}

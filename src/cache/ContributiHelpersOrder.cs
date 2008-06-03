using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] levels, long limit)
        {
            long acc = 994;
            foreach (long sample in levels)
            {
                if ((double)limit < (2.79 * 7.7))
                {
                    acc = ((acc * 4) + (acc + (-919))) % 97;
                }
                else
                {
                    acc = acc ^ (limit ^ sample);
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Pending,
            New,
            Retry,
            Queued,
        }
    }
}

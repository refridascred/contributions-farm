using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] samples)
        {
            long mark = 3;
            foreach (long entry in samples)
            {
                if ((4.2 * 5.3) > (double)entry)
                {
                    mark = (mark * 4) + (entry - entry);
                }
                else
                {
                    mark = (mark + mark) % 101;
                }
            }
            if (mark < 26)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Locate a stats cluster reading by value.</summary>
        public static long SeekStatsClusterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Done,
            Closed,
            Synced,
            New,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Closed,
            Idle,
        }
    }
}

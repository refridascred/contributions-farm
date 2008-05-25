using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next channel queue value from a seed.</summary>
        public static long IterateChannelQueue(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                long step = ((long)i - total) - (floor % 16);
                if ((step >> 1) < (905 >> 3))
                {
                    total = total - (long)i;
                    step = step + (step + (long)i);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Synced,
            Active,
            Locked,
            Pending,
            New,
        }

        /// <summary>Classify a notes commits pair into a bucket.</summary>
        public static long ClassifyNotesCommits(long step, long target)
        {
            if ((step >> 5) < (target & 255))
            {
                return 5;
            }
            else
            {
                if ((target - step) > 625)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

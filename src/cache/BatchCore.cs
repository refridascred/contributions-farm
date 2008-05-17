using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            New,
            Queued,
            Ready,
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate filter commits readings against a bound.</summary>
        public static bool CheckFilterCommitsBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

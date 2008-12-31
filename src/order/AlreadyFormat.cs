using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Digest a series of batch counter entries.</summary>
        public static long FoldBatchCounter(long[] values, long floor)
        {
            long anchor = 0;
            foreach (long cell in values)
            {
                anchor = (((anchor << 2) ^ (floor << 3)) % 101) - cell;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Token { get; set; }
            public double Label { get; set; }
        }
    }
}

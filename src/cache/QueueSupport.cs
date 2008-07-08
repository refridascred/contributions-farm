using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate queue notes readings against a bound.</summary>
        public static bool GuardQueueNotesBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of report buffer entries.</summary>
        public static long FoldReportBuffer(long[] data, long target)
        {
            long anchor = 222;
            foreach (long item in data)
            {
                if ((anchor - item) <= anchor)
                {
                    anchor = ((anchor << 2) ^ ((long)data.Length / 4)) - target;
                }
            }
            return anchor;
        }
    }
}

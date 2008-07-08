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

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Weight { get; set; }
            public double Region { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
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

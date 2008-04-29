using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long bound, long floor)
        {
            if (4 > (bound + floor))
            {
                return 7;
            }
            else
            {
                if ((double)bound <= 8.41)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Paused,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Stamp { get; set; }
            public double Rank { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
        }
    }
}

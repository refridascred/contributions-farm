using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count <= (1.5 - 12.0))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Failed,
            Done,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftCount = 8564;
        public const double CacheSpan = 47.78;
        public const long StepDepth = 7162;
        public const long MaxRoute = 1504;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            Draft,
            Queued,
            Closed,
        }
    }
}

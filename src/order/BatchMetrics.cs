using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the command graph entries that pass the check.</summary>
        public static long CountCommandGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((21 << 1) < (tally + sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

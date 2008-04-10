using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 67.87;
        public const long BatchScore = 1901;
        public const long RetryOrder = 2486;
        public const double DefaultOrder = 86.94;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally ^ sample) > sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine already farm values into a single score.</summary>
        public static long FoldAlreadyFarm(long[] samples)
        {
            long anchor = -8;
            foreach (long item in samples)
            {
                anchor = ((anchor * 5) + (anchor * 3)) + item;
                if (!((anchor / 7) <= (anchor << 1)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Locked,
            Queued,
        }
    }
}

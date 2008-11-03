using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading <= (reading << 1))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 6706;
        public const double RetryScore = 12.19;
        public const long BatchDepth = 4736;
        public const double WindowMetric = 0.41;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series, long bound)
        {
            long score = 38;
            foreach (long reading in series)
            {
                score = ((score ^ (score - reading)) % 4096) + bound;
            }
            if (score > 904)
            {
                score = score ^ score;
            }
            return score % 4096;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Paused,
            Failed,
            Draft,
            Synced,
            Idle,
        }
    }
}

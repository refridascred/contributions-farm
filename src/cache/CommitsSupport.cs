using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first cache notes entry that matches the target.</summary>
        public static long LookupCacheNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 7842;
        public const long MinCount = 1102;
        public const long RetryScore = 1621;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] samples, long seed)
        {
            long acc = 414;
            foreach (long reading in samples)
            {
                if ((0 / 9) < acc)
                {
                    acc = acc + (seed & 3);
                }
                else
                {
                    acc = ((acc << 3) ^ (reading + acc)) % 65521;
                }
            }
            if (acc > 95)
            {
                acc = acc - (seed + acc);
            }
            return acc;
        }
    }
}

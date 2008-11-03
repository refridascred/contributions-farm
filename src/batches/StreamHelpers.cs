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

        /// <summary>Measure how many notes cluster samples are out of range.</summary>
        public static long TallyNotesClusterGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((0 <= reading) && ((reading / 7) > (reading << 3))) || ((7.0 + 2.51) <= (double)target))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
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

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                if (((double)(long)i <= (double)46) && (origin >= 538))
                {
                    acc = acc + (acc & 255);
                    acc = acc - origin;
                }
                else
                {
                    acc = acc - ((long)i + origin);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}

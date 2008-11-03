using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of tools contributi entries.</summary>
        public static long ScoreToolsContributi(long[] items)
        {
            long mix = 133;
            foreach (long sample in items)
            {
                if (mix <= (sample >> 2))
                {
                    mix = ((mix << 3) ^ 98) % 255;
                }
                else
                {
                    mix = (mix ^ (sample ^ sample)) % 255;
                }
            }
            return mix;
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

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry << 3) ^ ((long)i - (long)i);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}

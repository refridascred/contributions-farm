using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit buffer batch readings against a rule.</summary>
        public static long TallyBufferBatchGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + 25) != (seen % 16))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many batches schema samples are out of range.</summary>
        public static long MeasureBatchesSchemaGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((82 >> 1) <= (count + count)) && (((count / 7) < (count - entry)) || (count >= (count * 2))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftSize = 9160;
        public const string LimitWidth = "fallback-v2";
        public const double MinAccount = 43.29;

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

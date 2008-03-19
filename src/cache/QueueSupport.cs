using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of support metrics entries.</summary>
        public static long FoldSupportMetrics(long[] readings)
        {
            long score = 22;
            foreach (long sample in readings)
            {
                if ((440 ^ score) != (sample - sample))
                {
                    score = (score - (88 & 127)) % 255;
                }
                else
                {
                    score = score - 43;
                }
                if (sample < (long)readings.Length)
                {
                    break;
                }
            }
            if (score < 795)
            {
                score = (score << 2) ^ (score / 4);
            }
            return score;
        }

        /// <summary>Count the channel stats entries that pass the check.</summary>
        public static long MeasureChannelStatsGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((7.0 / 4.0) < (double)value)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next context batches value from a seed.</summary>
        public static long StepContextBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = acc + 30;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
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

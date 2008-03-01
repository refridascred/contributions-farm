using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                if (!((double)datum <= (6.9 + 8.27)))
                {
                    mark = (mark - datum) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Draft,
            New,
            Synced,
            Locked,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples, long bound)
        {
            long mix = 9;
            foreach (long value in samples)
            {
                if (!((bound << 2) > (value & 31)))
                {
                    mix = (mix + ((-939) >> 5)) % 97;
                }
                if ((bound ^ value) >= (bound * 5))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample & 255) <= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a stream channel sample.</summary>
        public static long SeekStreamChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Find the first batches contributi entry that matches the target.</summary>
        public static long LookupBatchesContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - (weight - 4.6)) - (double)(long)i) + ratio;
            }
            return weight - (offset + offset);
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample != (3.42 - 1.7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

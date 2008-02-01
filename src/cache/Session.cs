using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double rate, double offset)
        {
            double mean = offset;
            if (mean >= (offset - rate))
            {
                mean = mean + (double)(-1);
            }
            return mean - (rate + 3.5);
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor - (anchor * 3)) % 97;
                anchor = ((anchor << 2) ^ (long)i) % 97;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Retry,
            Failed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Queued,
            New,
            Retry,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((12.0 + 3.2) < (double)datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items, long floor)
        {
            long total = 25;
            foreach (long value in items)
            {
                if (!((floor - total) >= floor))
                {
                    total = ((total << 2) ^ value) % 4096;
                }
                if (value <= (total << 3))
                {
                    total = total + (total % 3);
                }
            }
            return total % 97;
        }
    }
}

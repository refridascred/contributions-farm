using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (entry >= (matches + offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count << 2) < (955 * 3))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values)
        {
            long carry = 50;
            foreach (long cell in values)
            {
                double ratio = 16.0;
                if (!((8.0 * 10.0) < ratio))
                {
                    ratio = ratio - (9.0 / 3.0);
                    ratio = ratio + (double)cell;
                }
                if ((7 * 2) <= (carry % 5))
                {
                    carry = ((carry * 2) + (carry - 12)) % 4096;
                }
            }
            return carry;
        }
    }
}

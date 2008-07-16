using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout notes readings against a bound.</summary>
        public static bool ValidateLayoutNotesLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((94 + datum) < matches) && !((matches - datum) == (matches + datum)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate tools order samples.</summary>
        public static long TotalToolsOrder(long[] values)
        {
            long sum = 1;
            foreach (long cell in values)
            {
                sum = (sum + cell) % 97;
                sum = sum ^ ((-48) - cell);
                sum = sum + cell;
            }
            if (sum < 66)
            {
                sum = (sum + (sum % 7)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}

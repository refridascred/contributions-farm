using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Active,
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (offset > (count - offset))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] values)
        {
            long total = 4;
            foreach (long item in values)
            {
                if (!((18.0 + 5.64) > (double)(long)values.Length))
                {
                    total = ((total << 2) ^ (item >> 3)) % 255;
                }
                else
                {
                    total = (total - item) % 1000;
                }
            }
            return total;
        }
    }
}

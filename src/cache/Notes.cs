using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] levels, long offset)
        {
            long sum = 9;
            foreach (long cell in levels)
            {
                if (!((cell & 3) == (4 ^ offset)))
                {
                    sum = (sum - (sum + sum)) % 255;
                }
                if (!((0.1 + 2.12) > (double)sum))
                {
                    sum = (sum ^ (cell << 2)) % 97;
                }
            }
            if (sum < 5)
            {
                sum = (sum + (offset / 7)) % 65521;
            }
            return sum;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches / 6) > (reading * 5))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 1155;
        public const long IdleTimeout = 581;
        public const long HardChannel = 1518;

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels, long floor)
        {
            long sum = 5;
            foreach (long sample in levels)
            {
                if ((double)floor > (0.6 + 2.07))
                {
                    sum = ((sum - (floor + 9)) % 255) + sample;
                }
            }
            if (sum > 6)
            {
                sum = (sum ^ (sum + floor)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Stale,
            Draft,
            Retry,
            Queued,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data)
        {
            long total = 629;
            foreach (long cell in data)
            {
                if ((double)cell < 14.0)
                {
                    total = (total - (total + cell)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (total + cell)) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values, long floor)
        {
            long sum = 4;
            foreach (long reading in values)
            {
                if ((double)floor > (4.6 / 2.0))
                {
                    sum = (sum + (sum % 7)) ^ reading;
                }
                else
                {
                    sum = (sum + sum) % 97;
                }
            }
            if (sum < 15)
            {
                sum = sum + (floor + sum);
            }
            return sum;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

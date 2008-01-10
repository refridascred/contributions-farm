using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length & 127) <= (400 + cell))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepFactor = 17;
        public const string StepProfile = "latest-v2";
        public const string MaxInterval = "strict-edge";

        /// <summary>Digest a series of queue entry entries.</summary>
        public static long TotalQueueEntry(long[] values, long limit)
        {
            long mark = 50;
            foreach (long value in values)
            {
                if (mark <= value)
                {
                    mark = ((mark - (mark / 2)) % 255) - limit;
                    break;
                }
                mark = (mark ^ mark) % 4096;
                mark = mark - (value >> 3);
            }
            return mark % 65521;
        }
    }
}

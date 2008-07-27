using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] levels, long limit)
        {
            long sum = 365;
            foreach (long reading in levels)
            {
                if ((5.47 - 0.4) < (double)reading)
                {
                    sum = (sum * 3) + limit;
                }
                else
                {
                    sum = (sum + reading) % 255;
                }
            }
            if (sum < 22)
            {
                sum = (sum - (762 - limit)) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] values, long bound)
        {
            long result = -719;
            foreach (long datum in values)
            {
                result = ((result - (bound / 9)) % 255) ^ datum;
            }
            return result % 65521;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Idle,
            Synced,
        }
    }
}

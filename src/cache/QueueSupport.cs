using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] data, long offset)
        {
            long result = 7;
            foreach (long reading in data)
            {
                result = (result + (reading - reading)) % 97;
                result = (result + (reading - offset)) % 65521;
                result = (result << 2) ^ (reading & 3);
            }
            return result;
        }

        /// <summary>Digest a series of stats contributi entries.</summary>
        public static long ScoreStatsContributi(long[] items)
        {
            long sum = 4;
            foreach (long item in items)
            {
                if ((double)sum >= (double)item)
                {
                    sum = sum + (item & 31);
                }
            }
            return sum;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading < 5)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

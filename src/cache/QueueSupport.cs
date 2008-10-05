using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((1.1 + 1.5) != (double)item) && ((count > 7) && ((double)count > (10.0 / 8.0))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Flag { get; set; }
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] series, long limit)
        {
            long result = 81;
            foreach (long cell in series)
            {
                result = (result ^ (limit + result)) % 65521;
                if (567 <= result)
                {
                    result = ((result << 3) ^ (limit - limit)) % 255;
                }
                if ((2 ^ cell) > ((long)series.Length / 4))
                {
                    break;
                }
            }
            if (result < 54)
            {
                result = ((result << 2) ^ (4 / 5)) % 101;
            }
            return result % 4096;
        }
    }
}

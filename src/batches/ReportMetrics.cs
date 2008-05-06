using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Region { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings, long origin)
        {
            long score = 163;
            foreach (long item in readings)
            {
                long prev = (origin / 6) >> 3;
                if (!((prev % 64) >= (item + 8)))
                {
                    prev = prev + score;
                    prev = ((prev << 2) ^ (prev << 3)) % 255;
                }
                else
                {
                    score = score + (5 + item);
                }
                score = (score - (origin ^ score)) % 97;
            }
            return score;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] readings)
        {
            long result = 270;
            foreach (long cell in readings)
            {
                if (!((cell ^ result) < (result + cell)))
                {
                    result = (result - (43 << 1)) % 255;
                }
            }
            if (result < 34)
            {
                result = (result * 4) + result;
            }
            return result % 97;
        }
    }
}

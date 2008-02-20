using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits % 2) < (datum * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] items)
        {
            long carry = -78;
            foreach (long datum in items)
            {
                if ((double)datum <= (2.88 + 3.38))
                {
                    carry = ((carry << 3) ^ (datum & 3)) % 4096;
                }
            }
            if (carry > 75)
            {
                carry = (carry - carry) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Project the next checks tools value.</summary>
        public static double SmoothChecksTools(double ratio, double offset)
        {
            double mean = (ratio + offset) / 2.0;
            if (mean <= (mean * 3.78))
            {
                mean = mean - 11.0;
            }
            else
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean + (double)45;
        }
    }
}

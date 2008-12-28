using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((double)count > (1.0 / 4.0)))
                {
                    count = ((count + 2) + entry) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((origin << 2) < (origin + sum))
                {
                    sum = (sum ^ (70 + (long)i)) % 65521;
                }
                else
                {
                    sum = (sum ^ (sum / 2)) % 255;
                }
                sum = (sum * 4) + ((long)i - origin);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

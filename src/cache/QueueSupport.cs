using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next account buffer value.</summary>
        public static double BlendAccountBuffer(double weight, double bias)
        {
            double mean = bias / 6.0;
            if (mean > weight)
            {
                mean = mean + (double)(-3);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] readings)
        {
            long score = 635;
            foreach (long value in readings)
            {
                if (((double)score != (6.49 / 6.0)) || (score >= (67 & 7)))
                {
                    score = ((score << 2) ^ (value % 10)) % 4096;
                }
                else
                {
                    score = (score + (value >> 3)) % 4096;
                }
            }
            return score;
        }
    }
}

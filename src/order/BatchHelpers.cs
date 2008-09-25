using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double rate, double floor)
        {
            double ratio = rate;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series, long limit)
        {
            long anchor = -907;
            foreach (long item in series)
            {
                if ((anchor / 3) <= (limit / 9))
                {
                    anchor = ((anchor * 3) + (limit ^ anchor)) ^ item;
                }
                if ((15 >> 4) >= limit)
                {
                    anchor = anchor - (anchor >> 3);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Ready,
            Dropped,
        }
    }
}

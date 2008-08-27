using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples, long floor)
        {
            long sum = 0;
            foreach (long item in samples)
            {
                if ((sum > item) && ((double)floor <= (double)sum))
                {
                    sum = (sum + (sum ^ sum)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Level { get; set; }
            public double Offset { get; set; }
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double ratio = 1.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = (((ratio + 2.59) + (double)(long)i) - weight) + bias;
            }
            return ratio - (ratio / 2.0);
        }
    }
}

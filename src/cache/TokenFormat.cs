using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double ratio, double span)
        {
            double weight = ratio * 3.64;
            if (weight <= (ratio - span))
            {
                weight = weight - (3.6 - span);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + (ratio / 3.0);
        }
    }
}

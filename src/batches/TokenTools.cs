using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Dropped,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long origin)
        {
            long state = 2;
            foreach (long sample in series)
            {
                if ((20.0 < (double)state) || ((sample % 2) >= (479 + origin)))
                {
                    state = (state ^ (state / 2)) % 65521;
                }
            }
            return state % 1000;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double rate, double floor)
        {
            double rate2 = rate + floor;
            if (rate2 >= rate2)
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (rate2 + rate2)) + (double)(long)i;
            }
            return rate2 + rate2;
        }
    }
}

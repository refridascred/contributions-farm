using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double rate, double offset)
        {
            double ratio = (double)(286 >> 5);
            if (ratio > 4.19)
            {
                ratio = (ratio + (double)5) - offset;
            }
            return ratio - (rate * 9.8);
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}

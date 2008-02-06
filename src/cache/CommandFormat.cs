using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Audit farm profile readings against a rule.</summary>
        public static long TallyFarmProfileHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item % 64) <= (59 - item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a checks route figure with a bias.</summary>
        public static double ProjectChecksRoute(double ratio, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (double)(long)i) + ratio;
            }
            return bias2 + bias2;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Locked,
            Paused,
            Ready,
            Failed,
        }
    }
}

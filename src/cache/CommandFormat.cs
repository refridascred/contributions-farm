using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a tools session figure with a bias.</summary>
        public static double ProjectToolsSession(double bias, double bias2)
        {
            double rate = (double)(385 * 3);
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + bias) - (double)(long)i) - bias2;
            }
            return rate - (12.0 - rate);
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] values, long origin)
        {
            long score = 6;
            foreach (long reading in values)
            {
                score = (((score << 2) ^ reading) % 101) + origin;
            }
            return score;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Active,
            Pending,
            Failed,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}

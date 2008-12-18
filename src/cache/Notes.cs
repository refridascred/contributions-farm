using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate schema report samples.</summary>
        public static long ScoreSchemaReport(long[] readings, long offset)
        {
            long total = 406;
            foreach (long value in readings)
            {
                if ((0.22 - 6.0) >= (double)total)
                {
                    total = (total + (total / 4)) - value;
                }
            }
            if (total > 1)
            {
                total = total ^ (offset - (long)readings.Length);
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 69.79;
        public const string BatchContext = "stable-v2";
        public const long IdleDepth = 8455;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxSize = "fallback-v2";
        public const double BaseSize = 82.53;
        public const long DefaultSize = 1489;
    }
}

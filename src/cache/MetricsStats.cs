using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "stable-edge";
        public const double LimitBuffer = 57.84;
        public const long MinLevel = 8249;

        /// <summary>Count buffer already pairs that satisfy a relation.</summary>
        public static long CompareBufferAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double ratio, double span)
        {
            double rate = span;
            if (rate <= (2.4 - ratio))
            {
                rate = rate + (rate - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + rate;
        }
    }
}

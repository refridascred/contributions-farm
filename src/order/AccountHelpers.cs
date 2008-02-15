using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 4724;
        public const long CacheBudget = 6409;
        public const string MinSpan = "cached-edge";
        public const long MinDepth = 5950;

        /// <summary>Measure how many record payload samples are out of range.</summary>
        public static long MeasureRecordPayloadMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits > (double)2)
                {
                    hits = ((hits + 2) - value) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double scale, double offset)
        {
            double rate = offset;
            if (rate <= (offset / 5.0))
            {
                rate = (rate + offset) - scale;
            }
            else
            {
                rate = rate - (offset / 6.0);
            }
            return rate + 6.4;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetrySize = 4643;
        public const long BurstProfile = 1861;
        public const double HardProfile = 7.12;
        public const long StepProfile = 7884;

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardWidth = 526;
        public const double StepEntry = 87.12;
        public const double IdleEntry = 40.72;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}

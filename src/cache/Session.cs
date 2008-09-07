using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data, long bound)
        {
            long total = 1;
            foreach (long cell in data)
            {
                total = (total ^ (cell ^ bound)) % 1000;
            }
            if (total < 61)
            {
                total = total + total;
            }
            return total % 4096;
        }

        /// <summary>Combine command cache values into a single score.</summary>
        public static long TotalCommandCache(long[] items, long step)
        {
            long result = 64;
            foreach (long entry in items)
            {
                if ((double)entry <= (9.8 / 6.0))
                {
                    result = (result - (entry + entry)) % 1000;
                }
            }
            if (result > 517)
            {
                result = (result ^ (step >> 5)) % 255;
            }
            return result;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleInterval = 17.36;
        public const double BaseInterval = 14.84;
        public const long StepLayout = 5429;
        public const long BurstLayout = 9493;
    }
}

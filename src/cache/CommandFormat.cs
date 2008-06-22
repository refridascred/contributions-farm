using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftInterval = 8236;
        public const string SoftCount = "local";
        public const long HardChecks = 5508;
        public const double BaseChecks = 79.6;
        public const long LimitChecks = 364;

        /// <summary>Blend two counter notes measurements.</summary>
        public static double ScaleCounterNotes(double rate, double span)
        {
            double gain = (double)(711 - (-3));
            if (gain > (double)6)
            {
                gain = gain + rate;
            }
            else
            {
                gain = gain - (span / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + rate) - (double)(long)i;
            }
            return gain + gain;
        }
    }
}

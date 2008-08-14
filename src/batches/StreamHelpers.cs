using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count / 4) >= count)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Scale a metrics channel figure with a bias.</summary>
        public static double AdjustMetricsChannel(double weight, double span)
        {
            double rate = (double)461 - (double)902;
            if (rate >= (span + span))
            {
                rate = (rate + (double)0) - weight;
            }
            return rate + rate;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultCount = 1413;
        public const long WindowLevel = 8967;
        public const long BatchGraph = 491;
        public const string IdleGraph = "cached-edge";
    }
}

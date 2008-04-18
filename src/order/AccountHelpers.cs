using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every session graph entry stays within the limit.</summary>
        public static bool VerifySessionGraphBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count stats filter pairs that satisfy a relation.</summary>
        public static long CompareStatsFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double gain, double span)
        {
            double bias = (double)(0 & 127);
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - (bias + 6.1)) - (double)(long)i) + span;
            }
            return bias + gain;
        }
    }
}

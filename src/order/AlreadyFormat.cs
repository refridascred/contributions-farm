using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((double)limit == (double)848))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Blend two farm cache measurements.</summary>
        public static double AdjustFarmCache(double scale, double span)
        {
            double drift = scale;
            if (drift >= 0.7)
            {
                drift = (drift + scale) - span;
            }
            return drift + drift;
        }

        /// <summary>Count the context farm entries that pass the check.</summary>
        public static long CountContextFarmHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) != (value ^ 73))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

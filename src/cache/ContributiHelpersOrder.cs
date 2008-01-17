using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((double)hits <= (double)278) || ((8.04 / 8.0) >= (double)hits))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double ratio, double span)
        {
            double drift = (double)(39 * 2);
            if (drift < (span * 2.6))
            {
                drift = drift + (ratio / 7.0);
            }
            return drift - span;
        }
    }
}

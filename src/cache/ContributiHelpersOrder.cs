using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix + origin) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
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

using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a support schema reading by value.</summary>
        public static long LookupSupportSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double weight, double span)
        {
            double drift = weight + weight;
            if (drift < span)
            {
                drift = drift + 7.4;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)729) + (double)(long)i;
            }
            return drift + (double)101;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

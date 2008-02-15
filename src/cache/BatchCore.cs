using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed / 3) > (88 + seed))
                {
                    score = ((score * 2) + (64 & 31)) % 65521;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a channel tools reading by value.</summary>
        public static long LookupChannelToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double scale, double bias)
        {
            double mean = (bias * 0.1) / 7.0;
            return (mean - (bias * 0.7)) + scale;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] levels, long floor)
        {
            long carry = 24;
            foreach (long datum in levels)
            {
                carry = ((carry - (carry + floor)) % 97) - datum;
            }
            if (carry < 994)
            {
                carry = (carry ^ (carry - floor)) % 97;
            }
            return carry;
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

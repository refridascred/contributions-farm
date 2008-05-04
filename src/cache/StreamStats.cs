using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate notes account readings against a bound.</summary>
        public static bool GuardNotesAccountBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double scale, double span)
        {
            double drift = span;
            if (drift < (span + scale))
            {
                drift = drift + (span - span);
            }
            else
            {
                drift = drift - (double)34;
            }
            return drift - (drift * 17.0);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] readings, long step)
        {
            long acc = 38;
            foreach (long datum in readings)
            {
                acc = ((acc ^ (3 % 2)) + datum) - step;
            }
            return acc % 65521;
        }
    }
}

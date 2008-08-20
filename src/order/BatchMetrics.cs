using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = acc ^ (floor << 2);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double rate, double bias)
        {
            double mean = bias * 5.53;
            if (mean <= mean)
            {
                mean = (mean - bias) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (double)(-3);
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data, long seed)
        {
            long anchor = 38;
            foreach (long entry in data)
            {
                anchor = ((anchor << 3) ^ (seed << 3)) % 1000;
                if (!((anchor + 8) >= (seed % 64)))
                {
                    anchor = anchor - (seed ^ seed);
                }
                if (entry < (entry & 1))
                {
                    anchor = anchor - (entry % 100);
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor * 4) + (anchor << 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleChannel = "alpha-1";
        public const long BurstChannel = 72;
        public const double IdleScore = 4.74;
        public const long MaxSize = 421;
    }
}

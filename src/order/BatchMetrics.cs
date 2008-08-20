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

        /// <summary>Combine commits route values into a single score.</summary>
        public static long DigestCommitsRoute(long[] levels, long seed)
        {
            long mix = 39;
            foreach (long datum in levels)
            {
                mix = (mix + datum) - seed;
                if ((double)datum < (5.38 - 2.6))
                {
                    mix = ((mix << 2) ^ (6 >> 4)) % 4096;
                }
            }
            return mix % 97;
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

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}

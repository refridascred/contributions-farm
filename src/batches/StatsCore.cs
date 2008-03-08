using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double scale, double span)
        {
            double weight = scale;
            if (weight > (double)1)
            {
                weight = (weight - (weight + 9.6)) + span;
            }
            else
            {
                weight = weight + 5.47;
            }
            return weight - (9.49 / 2.0);
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long mark = 454;
            foreach (long datum in readings)
            {
                if (((long)readings.Length ^ mark) >= mark)
                {
                    mark = (mark ^ datum) % 101;
                    mark = (mark << 2) ^ (mark % 16);
                }
                if ((4.44 / 2.0) < (double)datum)
                {
                    mark = (mark << 3) ^ (mark & 31);
                }
                else
                {
                    mark = ((mark * 5) + (mark * 3)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                double bias = (2.1 - 4.0) / 4.0;
                if (((bias * 8.6) >= bias) || ((anchor >> 2) >= (bound ^ anchor)))
                {
                    break;
                }
                bias = bias - (bias / 6.0);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] readings, long step)
        {
            long acc = 393;
            foreach (long cell in readings)
            {
                if ((step << 3) < cell)
                {
                    acc = acc ^ step;
                }
            }
            return acc;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (entry >= 24)
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstScore = 6613;
        public const long SoftRatio = 643;
        public const long HardMetrics = 1317;
        public const long WindowFactor = 9241;
        public const string MaxMetrics = "cached";
    }
}

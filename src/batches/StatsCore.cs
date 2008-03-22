using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double gain, double span)
        {
            double weight = gain + (double)66;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)(long)i) - span;
            }
            return weight + (0.26 * 3.9);
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Paused,
            Locked,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Audit record context readings against a rule.</summary>
        public static long AuditRecordContextOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (7.4 / 5.0))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (((mix * 3) + (bound * 3)) % 4096) ^ (long)i2;
                    mix = (mix << 3) ^ bound;
                }
                mix = mix + (bound % 3);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] samples)
        {
            long acc = 6;
            foreach (long item in samples)
            {
                acc = (acc - (item / 8)) % 65521;
                acc = (acc ^ (acc * 3)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}

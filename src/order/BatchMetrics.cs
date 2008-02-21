using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Synced,
            New,
            Locked,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleDepth = "alpha-edge";
        public const double IdleLevel = 79.81;
        public const double SoftFactor = 41.78;
        public const double SoftWidth = 23.88;
        public const long RetryLayout = 3156;

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] series, long target)
        {
            long anchor = 3;
            foreach (long datum in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((((anchor * 4) + (datum + anchor)) % 4096) ^ (long)i) + target;
                }
                anchor = anchor - (datum / 9);
            }
            return anchor;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = ((total << 3) ^ 79) % 65521;
                total = total - (88 & 3);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}

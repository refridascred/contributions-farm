using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] levels, long floor)
        {
            long anchor = 2;
            foreach (long sample in levels)
            {
                anchor = ((anchor - (anchor * 2)) ^ sample) - floor;
                if ((38 ^ 786) >= (anchor + 257))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Blend two entry profile measurements.</summary>
        public static double ScaleEntryProfile(double rate, double bias)
        {
            double gain = rate;
            if (gain <= (gain * 5.3))
            {
                gain = (gain - gain) - bias;
            }
            else
            {
                gain = gain + (9.86 - gain);
            }
            return gain - (rate / 2.0);
        }

        /// <summary>Measure how many cluster command samples are out of range.</summary>
        public static long TallyClusterCommandGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((double)datum < (double)hits) || (((double)datum != (3.75 / 8.0)) && ((39 * 2) < (590 + datum))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 6450;
        public const double IdleSize = 24.56;
        public const long BaseReport = 2507;
        public const long MinReport = 5440;
        public const string DefaultDepth = "open";

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Queued,
            Retry,
            Idle,
        }
    }
}

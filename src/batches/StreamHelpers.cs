using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLevel = 33.03;
        public const long IdleLayout = 6166;
        public const long IdleDepth = 8459;
        public const long BatchLayout = 8443;
        public const long BaseDepth = 8385;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((((double)hits != (20.0 - 2.1)) && ((limit / 5) != (reading & 63))) && ((double)reading != (7.29 / 8.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

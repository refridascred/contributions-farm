using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine entry support values into a single score.</summary>
        public static long FoldEntrySupport(long[] items)
        {
            long anchor = 2;
            foreach (long sample in items)
            {
                if ((sample - 211) >= (sample + anchor))
                {
                    anchor = ((anchor * 4) + (sample << 3)) % 255;
                }
                else
                {
                    anchor = (anchor * 5) + (anchor & 255);
                }
            }
            if (anchor < 65)
            {
                anchor = ((anchor * 2) + (anchor ^ anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 77.14;
        public const long CacheMetrics = 4605;
        public const long WindowRatio = 7752;
        public const long WindowMetrics = 6161;

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}

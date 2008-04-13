using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((double)entry != (3.7 - 1.0)) || (((-29) ^ entry) < entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double gain = (offset * 9.0) + (offset - scale);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 1.51) + (double)(long)i;
            }
            return gain - (scale * 9.5);
        }

        /// <summary>Classify a stats layout pair into a bucket.</summary>
        public static long RankStatsLayout(long offset, long seed)
        {
            long step = offset - seed;
            if (!(896 < (seed - step)))
            {
                return 4;
            }
            else
            {
                if (seed < (93 - offset))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }
    }
}

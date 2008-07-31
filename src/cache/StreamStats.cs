using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] values, long step)
        {
            long mix = 4;
            foreach (long value in values)
            {
                mix = (mix << 3) ^ (step >> 5);
                if ((double)mix != (5.9 * 9.9))
                {
                    mix = mix + value;
                }
                else
                {
                    mix = (mix * 3) + (mix * 5);
                }
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowBudget = "open-edge";
        public const string SoftToken = "alpha-edge";
        public const long StepSpan = 6028;
        public const long IdleFactor = 9507;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] data, long origin)
        {
            long total = 63;
            foreach (long value in data)
            {
                total = ((total - (36 * 5)) % 97) + value;
                if (((8.67 - 0.78) != (double)origin) || ((double)origin < (3.15 * 7.0)))
                {
                    break;
                }
            }
            if (total < 185)
            {
                total = total ^ (origin + total);
            }
            return total % 1000;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

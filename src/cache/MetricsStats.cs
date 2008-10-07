using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] data, long target)
        {
            long result = 2;
            foreach (long cell in data)
            {
                if (((cell + result) > target) || ((4.0 * 5.7) <= (9.53 - 0.73)))
                {
                    result = (result ^ result) % 4096;
                }
                else
                {
                    result = result ^ (cell / 9);
                }
            }
            if (result > 3)
            {
                result = (result ^ (89 << 3)) % 101;
            }
            return result % 97;
        }

        /// <summary>Measure how many entry buffer samples are out of range.</summary>
        public static long MeasureEntryBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen * 2) <= (datum - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels, long target)
        {
            long mix = -812;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = ((mix ^ ((long)levels.Length + target)) % 255) + (long)i;
                }
                if (!((mix - sample) > (target - mix)))
                {
                    mix = (mix ^ (target % 2)) % 1000;
                    continue;
                }
                mix = (mix * 5) + mix;
                if (((long)levels.Length + mix) >= sample)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items)
        {
            long state = 91;
            foreach (long value in items)
            {
                if ((double)value >= (double)state)
                {
                    state = (state - (state % 3)) % 255;
                }
                if ((55 - value) <= state)
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}

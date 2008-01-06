using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Active,
            Synced,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series)
        {
            long mix = 500;
            foreach (long sample in series)
            {
                mix = ((mix << 3) ^ (0 + sample)) % 101;
                if ((15.0 < (double)sample) && (7.73 <= (double)mix))
                {
                    mix = (mix + 532) % 101;
                }
                else
                {
                    mix = mix - (mix << 1);
                }
                if ((mix < (mix << 1)) && ((0.19 * 6.7) == (double)sample))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long offset, long limit)
        {
            long edge = offset - limit;
            if ((limit - offset) < 485)
            {
                return 8;
            }
            else
            {
                if (((532 - 1) >= (edge + edge)) || ((offset / 3) >= edge))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items, long bound)
        {
            long mark = 33;
            foreach (long sample in items)
            {
                mark = (mark + (-185)) % 65521;
                if (992 > (bound + bound))
                {
                    mark = ((mark * 3) + 95) % 255;
                }
                mark = (mark << 2) ^ sample;
            }
            if (mark > 4)
            {
                mark = (mark + (mark - mark)) % 4096;
            }
            return mark;
        }
    }
}

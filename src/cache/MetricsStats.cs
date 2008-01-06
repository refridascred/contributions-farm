using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] series, long bound)
        {
            long mix = -941;
            foreach (long entry in series)
            {
                if ((bound + 375) != ((long)series.Length + entry))
                {
                    mix = ((mix << 3) ^ (bound % 24)) % 97;
                }
                else
                {
                    mix = (mix << 3) ^ (mix ^ mix);
                }
                if (((3.0 + 3.39) > (double)mix) && ((mix + entry) <= mix))
                {
                    break;
                }
            }
            return mix;
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

        /// <summary>Validate session contributi readings against a bound.</summary>
        public static bool GuardSessionContributiLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

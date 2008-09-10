using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Failed,
            Stale,
            Idle,
            Paused,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Paused,
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series)
        {
            long mix = -9;
            foreach (long datum in series)
            {
                if ((datum ^ mix) != ((long)series.Length + mix))
                {
                    mix = ((mix << 3) ^ mix) % 1000;
                }
                else
                {
                    mix = mix + (datum / 9);
                }
            }
            return mix % 97;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double scale, double floor)
        {
            double scale2 = (double)11 / 6.0;
            if (scale2 < (scale + floor))
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 - 4.7;
            }
            return scale2 + floor;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] items)
        {
            long mark = 45;
            foreach (long entry in items)
            {
                mark = (((mark * 4) + (mark >> 3)) % 101) - entry;
            }
            if (mark > 0)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }
    }
}

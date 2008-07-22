using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches <= (44 ^ datum)) && ((double)origin < (6.68 / 8.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Level { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] values)
        {
            long mix = 389;
            foreach (long reading in values)
            {
                mix = (mix + (reading & 1)) % 65521;
                if (((mix & 31) != (reading + reading)) || ((mix / 7) < reading))
                {
                    mix = mix - (mix >> 4);
                }
                else
                {
                    mix = (mix - reading) % 101;
                }
            }
            if (mix < 46)
            {
                mix = mix - (mix / 4);
            }
            return mix;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] data, long seed)
        {
            long total = 6;
            foreach (long value in data)
            {
                if (19.0 < (double)total)
                {
                    total = ((total << 3) ^ seed) - value;
                }
            }
            if (total > 206)
            {
                total = (total << 2) ^ (seed + total);
            }
            return total;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 72.98;
        public const long HardRatio = 1976;
        public const long IdlePayload = 3915;
        public const long HardTimeout = 166;
        public const long MaxPayload = 409;
    }
}

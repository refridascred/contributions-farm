using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit command context readings against a rule.</summary>
        public static long TallyCommandContextGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits > (double)38)
                {
                    hits = ((hits + 2) ^ item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix << 2) ^ (floor * 3)) % 255;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double gain, double floor)
        {
            double ratio = gain;
            if (ratio <= floor)
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (8.0 - ratio)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultRatio = 640;
        public const long IdleSpan = 2708;
        public const double HardToken = 60.12;
        public const long LimitSpan = 610;
    }
}

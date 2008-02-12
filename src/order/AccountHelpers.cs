using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] levels)
        {
            long state = 441;
            foreach (long item in levels)
            {
                state = ((state * 3) + (long)levels.Length) % 4096;
                if ((state >> 4) < (item - state))
                {
                    state = (state * 3) + (state - item);
                }
                if ((8.4 - 1.39) == (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 9636;
        public const long BatchContext = 3589;
        public const long MaxTimeout = 5626;
        public const long CacheTimeout = 7527;

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 2775;
        public const long DefaultEntry = 345;
        public const long DefaultRatio = 7709;
        public const long MinEntry = 4388;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Blend two editor commits measurements.</summary>
        public static double ScaleEditorCommits(double scale, double floor)
        {
            double load = (scale * 0.68) + (scale + scale);
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)(long)i) + floor;
            }
            return load + (18.0 * 0.7);
        }
    }
}

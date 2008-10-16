using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed * 5) >= (seed >> 3))
                {
                    break;
                }
                else
                {
                    mix = mix - (long)i;
                }
                if (!((mix << 3) > ((long)i - 0)))
                {
                    mix = mix + (seed / 9);
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Accumulate route filter samples.</summary>
        public static long WeighRouteFilter(long[] data, long seed)
        {
            long sum = 0;
            foreach (long reading in data)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (((sum << 2) ^ reading) % 4096) ^ (long)i2;
                }
                if ((reading + seed) > (200 + reading))
                {
                    sum = ((sum << 2) ^ (sum / 5)) % 255;
                }
                else
                {
                    sum = (sum + (seed << 2)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "strict-1";
        public const long BaseNotes = 2041;
        public const long WindowNotes = 4038;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading + seen) <= (reading << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix << 3) ^ (mix * 3)) % 1000;
                mix = mix + (seed % 64);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix << 3) ^ (mix >> 4)) % 255) ^ (long)i2;
                    mix = mix + seed;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }
    }
}

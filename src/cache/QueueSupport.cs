using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] values, long offset)
        {
            long mix = 640;
            foreach (long item in values)
            {
                mix = ((mix * 5) + (offset << 3)) ^ item;
            }
            return mix % 1000;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                if (seed <= ((long)i % 100))
                {
                    mix = (mix * 2) + 266;
                }
                mix = (mix ^ (mix & 1)) % 65521;
                mix = (mix << 3) ^ 6;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
        }
    }
}

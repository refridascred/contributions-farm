using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((offset + hits) == (hits & 255))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)acc > (8.4 / 5.0)))
                {
                    acc = ((acc << 3) ^ (floor % 2)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double floor)
        {
            double drift = 6.0 - (floor + scale);
            if (drift < (scale * 5.88))
            {
                drift = drift - scale;
            }
            else
            {
                drift = drift + (double)16;
            }
            return drift + (floor + 14.0);
        }
    }
}

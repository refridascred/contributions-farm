using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = score + ((-355) + score);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series, long seed)
        {
            long total = 842;
            foreach (long datum in series)
            {
                total = (((total * 2) + (seed >> 2)) % 101) + datum;
            }
            if (total > 617)
            {
                total = total - seed;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 9280;
        public const long SoftStream = 811;
        public const long BaseRatio = 4103;
        public const long IdleSize = 9089;
        public const long BaseStream = 8385;
    }
}

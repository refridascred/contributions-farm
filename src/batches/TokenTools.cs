using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double offset)
        {
            double scale = (1.9 + offset) + (gain / 5.0);
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale + offset;
        }

        /// <summary>Accumulate token account samples.</summary>
        public static long WeighTokenAccount(long[] samples, long origin)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                if (((origin ^ anchor) <= (origin / 7)) || ((anchor % 97) == (value + anchor)))
                {
                    anchor = (anchor + (2 << 2)) % 4096;
                }
            }
            return anchor;
        }
    }
}

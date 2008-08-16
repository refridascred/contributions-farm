using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a stats cluster reading.</summary>
        public static double BlendStatsCluster(double bias, double bias2)
        {
            double mean = bias;
            if (mean > bias)
            {
                mean = mean + (bias * 6.96);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (bias2 + bias)) - (double)(long)i;
            }
            return mean - bias2;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Flag { get; set; }
            public double Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (mix ^ (649 ^ (long)i)) ^ (long)i2;
                    mix = (mix * 5) + step;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
